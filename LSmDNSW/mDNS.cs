
using System;                           // for Serializable
using System.Runtime.InteropServices;   // for StructLayout

using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Collections;               // for ArrayList
using gClass;
using DataClass;

namespace LSmDNSW
{
    #region // class 

    public class Query 
	{
        string domain;

        protected ushort QueryType { get; set; }
        public ushort QueryClass { get { return 1; } }

        public Query( string name ) {
            QueryType = 0;
            // validate name
            domain = name;
        }

        virtual public byte[] GetBytes() {
            PacketBuilder packet = new PacketBuilder();
            packet.Add( domain );
            packet.Add( QueryType );
            packet.Add( QueryClass );
            return packet.GetBytes();
        }
    }

    public class QueryA : Query {
        public QueryA( string name ) : base(name) { QueryType = 1; }
    }

    public class QueryCNAME : Query {
        public QueryCNAME( string name ) : base(name) { QueryType = 5; }
    }

    public class QueryPTR : Query {
        public QueryPTR( string name ) : base(name) { QueryType = 12; }
    }

    public class QueryTXT : Query {
        public QueryTXT( string name ) : base(name) { QueryType = 16; }
    }

    public class QueryAAAA : Query {
        public QueryAAAA( string name ) : base(name) { QueryType = 28; }
    }

    public class QuerySRV : Query {
        public QuerySRV( string name ) : base(name) { QueryType = 33; }
    }

    class Resource 
	{
		public string domain { get; set; }
        protected ushort resource_type;
        protected ushort resource_class = 1; // IN
        public int ttl { get; set; }

        public Resource( string s ) {
	    domain = s;
	    ttl = 2000;
        }

        public Resource( string s, ushort _type ) {
	    domain = s;
            resource_type = _type;
	    ttl = 2000;
        }

        public Resource( PacketParser packet, string s, int length ) 
		{
			if (length == 0)
				return;
	    domain = s;
#pragma warning disable 219
	    byte[] rdata = packet.PopBytes( length );
#pragma warning restore 219
        }

    }

    class TargetResource : Resource 
	{
		public string target { get; set; }
        public TargetResource( string domain ) : base(domain) { }
        public TargetResource( string domain, ushort type )
               : base(domain, type) { }
    }

    class AddressResource : Resource {
	public IPAddress address { get; set; }
        public AddressResource( string domain ) : base(domain) { }
        public AddressResource( string domain, ushort type )
               : base(domain, type) { }
    }

    class A : AddressResource { // 1
        public A( PacketParser packet, string domain, int length ) : base(domain, 1) 
		{
			if (length == 0)
				return;
		    byte[] rdata = packet.PopBytes( length );
			if (rdata.Length < 1)
			{
				//Console.WriteLine("====> Data Length..");
				return;
			}
		    address = new IPAddress( rdata );
        }
    }

    class CNAME : TargetResource { // 5
        public CNAME( PacketParser packet, string domain, int length )
	: base(domain, 5) {
	    target = packet.PopDomain();
        }
    }

    class PTR : TargetResource { // 12
        public PTR( PacketParser packet, string domain, int length )
	: base(domain, 12) {
	    target = packet.PopDomain();
        }
    }

    class TXT : Resource { // 16
	public string txt { get; set; }
        public TXT( PacketParser packet, string domain, int length )
	: base(domain, 16) {
	    txt = packet.PopString();
        }
    }

    class AAAA : AddressResource { // 28
        public AAAA( PacketParser packet, string domain, int length )
	: base(domain, 28) {
	    byte[] rdata = packet.PopBytes( length );
	    address = new IPAddress( rdata );
        }
    }

    class SRV : TargetResource 
	{ // 33
		public ushort port { get; set; }
		public ushort priority { get; set; }
		public ushort weight { get; set; }

        public SRV( PacketParser packet, string domain, int length ) : base(domain, 33) 
		{
			priority = packet.PopUShort();
			weight = packet.PopUShort();
			port = packet.PopUShort();
			target = packet.PopDomain();
        }
    }

	#endregion

	#region // Service, 
	public class Service 
	{
		public string domain { get; set; }
		public string target { get; set; }
		public ushort port { get; set; }

		public Service( string _domain, string _target, ushort _port ) 
		{
			domain = _domain;
			target = _target;
			port = _port;
		}
    }

    public class Message 
	{
		protected ushort id;
		protected ushort flags = 0;

		protected ArrayList questions   = new ArrayList();
        protected ArrayList answers     = new ArrayList();
        protected ArrayList servers     = new ArrayList();
        protected ArrayList additionals = new ArrayList();

        public Message() {
            System.Random generator = new System.Random();
            id = (ushort)generator.Next(1<<16);
        }

		public ArrayList
		GetResources() {
			ArrayList resources = new ArrayList();
			try
			{
				resources.AddRange(answers);
				resources.AddRange(servers);
				resources.AddRange(additionals);
			}
			catch (Exception e1)
			{
				Console.WriteLine("ERR.. GetResources");
			}
			return resources;
		}

		private Resource PopResource( PacketParser packet ) 
		{
			string domain = packet.PopDomain();
			if (domain == "")
				return null;
			ushort rr_type = packet.PopUShort();
	#pragma warning disable 219
			ushort rr_class = packet.PopUShort();
			int ttl = packet.PopInt();
	#pragma warning restore 219
			ushort length = packet.PopUShort();

			switch ( rr_type )
			{
				case  1: return new A( packet, domain, length );
				case  5: return new CNAME( packet, domain, length );
				case 12: return new PTR( packet, domain, length );
				case 16: return new TXT( packet, domain, length );
				case 28: return new AAAA( packet, domain, length );
				case 33: return new SRV(packet, domain, length);
				case 47: return new Resource(packet, domain, length);
				default:
//					return null;
///*
					// System.Console.WriteLine( "Unknown RR ({0}/{1})", rr_type, rr_class );
					if (length == 0)
						return null;
					return new Resource( packet, domain, length );
//*/
			}

		}

		public Message( byte[] data ) 
			{
			PacketParser packet = new PacketParser( data );

			id = packet.PopUShort();
			flags = packet.PopUShort();
			ushort question_count = packet.PopUShort();
			ushort answer_count = packet.PopUShort();
			ushort server_count = packet.PopUShort();
			ushort additional_count = packet.PopUShort();

			for ( int i = 0 ; i < question_count ; ++i ) {
	#pragma warning disable 219
			string domain = packet.PopDomain();
			ushort rr_type = packet.PopUShort();
			ushort rr_class = packet.PopUShort();
	#pragma warning restore 219
			}

			for ( int i = 0 ; i < answer_count ; ++i ) 
			{
				var t1 = PopResource(packet);
				if (t1 != null)
					answers.Add( t1);
			}

			for ( int i = 0 ; i < server_count ; ++i ) 
			{
				var t1 = PopResource(packet);
				if (t1 != null)
					servers.Add( t1);
			}

			for ( int i = 0 ; i < additional_count ; ++i ) 
			{
				var t1 = PopResource(packet);
				if(t1 != null)
					additionals.Add(t1);
			}
		}

        virtual public byte[] GetBytes() {

            PacketBuilder packet = new PacketBuilder();
            packet.Add( id );
            packet.Add( flags );
            packet.Add( (ushort)questions.Count );
            packet.Add( (ushort)answers.Count );
            packet.Add( (ushort)servers.Count );
            packet.Add( (ushort)additionals.Count );

            foreach ( Query query in questions ) {
                packet.Add( query.GetBytes() );
            }

            return packet.GetBytes();
        }

        public void Transmit( Resolver socket ) {
            socket.Send( this );
        }

		public override string ToString() {
			string result = "Response(";
			result +=  "Q:" + questions.Count;
			result += ",A:" + answers.Count;
			result += ",S:" + servers.Count;
			result += ",+:" + additionals.Count;
			result += ")";
			return result;
		}

		public void Write() {
			System.Console.WriteLine( ToString() );
				foreach ( Resource resource in answers ) {
				System.Console.WriteLine( "  " + resource.domain );
			}
		}
    }
	#endregion


	#region // Message 

	public class Request : Message 
	{

        public Request() : base() { }

        public Request( Query query ) : base() {
            Add( query );
        }

        // request A record
        public Request( string name ) : base() {
            Add( name );
        }

        public Request( byte[] data ) { }

        public void Add( Query query ) {
            questions.Add( query );
        }

        // if just ask for a name, then query for A
        // maybe also AAAA
        public void Add( string name ) {
            Add( new QueryA(name) );
        }

    }

    public class Response : Message 
	{
	// Not yet used for anything - would only be for server
        public Response() : base() {
            flags |= 0x8000;
        }

        public Response( byte[] data ) : base(data) {
		}

    }

    struct IPv4 {
        static public IPAddress Address = IPAddress.Parse( "224.0.0.251" );
        static public IPEndPoint TransmitEndPoint = new IPEndPoint( Address, 5353 );
        static public IPEndPoint ReceiveEndPoint = new IPEndPoint( IPAddress.Any, 5353 );
    }

    struct IPv6 {
        static public IPAddress Address = IPAddress.Parse( "ff02::fb" );
        static public IPEndPoint TransmitEndpoint = new IPEndPoint( Address, 5353 );
        static public IPEndPoint ReceiveEndPoint = new IPEndPoint( IPAddress.Any, 5353 );
    }

	#endregion

	#region // Resolver

	public class Resolver 
	{
        UdpClient socket;
		ArrayList resources = new ArrayList();
		IAsyncResult ar_ = null;

		public static int intfindx = 0;
		public static string localIP = "127.0.0.1";
		public Resolver() 
		{
            socket = new UdpClient();

            socket.Client.SetSocketOption( SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true );

			IPEndPoint ReceiveEndPoint1 = new IPEndPoint(System.Net.IPAddress.Parse(localIP), 5353);

			socket.Client.Bind( ReceiveEndPoint1 );


			int ttl = 255;	// local network packets - rfc3171
			socket.Client.SetSocketOption( SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, ttl );

			//int intfindx = BestInterfaceIndex();
			var options = new MulticastOption( IPv4.Address, intfindx );
			socket.Client.SetSocketOption( SocketOptionLevel.IP, SocketOptionName.AddMembership, options );
        }

		public void StartListening()
		{
			ar_ = socket.BeginReceive(Receive, new object());
			//Thread.Sleep(5000);
		}

		private void Receive(IAsyncResult ar)
		{
			try
			{
				if (socket != null)
				{
					IPEndPoint ip = new IPEndPoint(IPAddress.Any, 0);
					byte[] buffer = socket.EndReceive(ar, ref ip);

					if (buffer.Length > 1)
					{ 
						Console.WriteLine("RX2:" + buffer.Length.ToString());
						var res = new Response(buffer);
						resources.AddRange(res.GetResources());
					//OnReceiveMessage?.Invoke("");
					}
				}
			}
			catch (Exception e1)
			{
				Console.WriteLine(e1.Message);
			}
			finally
			{ 
				StartListening();
			}

		}
		public delegate void ReceiveMessageHandler(string message);
		public event ReceiveMessageHandler OnReceiveMessage;

		public bool rcvAddress()
		{
			foreach (Resource t1 in resources)
			{
				if (!(t1 is A)) continue;
				return true;
			}
			return false;
		}

		public short Send( Message message ) 
		{
            byte[] data = message.GetBytes();
            socket.Send( data, data.Length, IPv4.TransmitEndPoint );
            return 0;
        }

		public static int BestInterfaceIndex() 
		{
			NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
			foreach ( NetworkInterface nic in nics ) 
			{
				if ( nic.NetworkInterfaceType != NetworkInterfaceType.Ethernet ) continue;
				if ( nic.Supports(NetworkInterfaceComponent.IPv4) == false ) continue;
				IPInterfaceProperties properties = nic.GetIPProperties();
				IPv4InterfaceProperties v4_props = properties.GetIPv4Properties();
				g.Log("listening on interface: {0}" + nic.Name );
				return v4_props.Index;
			}
			throw new SystemException("could not find an interface index");
		}

		public Response Receive() 
		{
			//Thread.Sleep(20);
			byte[] bytes = {0};
		 	try
			{
				IPEndPoint sender = new IPEndPoint( IPAddress.Any, 0 );;
				//if(socket.Client.Connected)	
				bytes = socket.Receive( ref sender );
			}
			catch (Exception e1)
			{ 
			}
			if (bytes.Length > 1)
			{
				//Console.WriteLine("RX1:" + bytes.Length.ToString());
				return new Response(bytes);
			}
			else
				return null;
		}

		public void GatherResponses() 
		{
			//Response response;
			while (true) 
			{
				var response = Receive();
				var t1 = response.GetResources();
				if (t1.Count > 0)
				{ 
					//Console.WriteLine(response.ToString());
					resources.AddRange(t1);
				}
			}
		}

		private static void ReceiverThread( Object arg ) 
		{
			Thread.CurrentThread.Name = "ResolveListenerThread";
			Resolver receiver = (Resolver)arg;
			try 
			{
				receiver.GatherResponses();
			} 
			catch (Exception e ) 
			{
				// ignore
				//System.Console.WriteLine( "resolver thread aborted" );
				//System.Console.WriteLine( "message: {0}", e.Message );
				//System.Console.WriteLine( "source: {0}", e.Source );
				//System.Console.WriteLine( "stack: {0}", e.StackTrace );
				//System.Console.WriteLine( "data: {0}", e.Data );

			}
		}

		public void GatherResources() 
		{
			try 
			{
				Thread thread = new Thread( ReceiverThread );
				thread.Start( this );
				Thread.Sleep(5000);
				thread.Abort();
				thread.Join();
			}
			catch (System.Threading.ThreadAbortException e)
			{
				Thread.ResetAbort();
			}
			catch (Exception e1)
			{ 
			}
		}

		public string[] AAAAs(string domain)
		{
			ArrayList ptrs = new ArrayList();
			foreach (Resource resource in resources)
			{
				if (!(resource is AAAA)) continue;
				if (resource.domain.Trim('.') != domain) continue;
				AAAA ptr = (AAAA)resource;
				ptrs.Add(ptr.domain);
			}
			return (string[])ptrs.ToArray(typeof(string));
		}

		public string[] CNAMEs(string domain)
		{
			ArrayList ptrs = new ArrayList();
			foreach (Resource resource in resources)
			{
				if (!(resource is CNAME)) continue;
				if (resource.domain.Trim('.') != domain) continue;
				CNAME ptr = (CNAME)resource;
				ptrs.Add(ptr.target);
			}
			return (string[])ptrs.ToArray(typeof(string));
		}

		public string[] PTRs( string domain ) {
			ArrayList ptrs = new ArrayList();
			foreach ( Resource resource in resources ) 
			{
				if ( ! (resource is PTR) ) continue;
				if ( resource.domain.Trim('.') != domain ) continue;
				PTR ptr = (PTR)resource;
				ptrs.Add( ptr.target );
			}
			return (string[])ptrs.ToArray( typeof(string) );
		}

		public Service[] SRVs( string domain ) 
		{
			ArrayList srvs = new ArrayList();
			foreach ( Resource resource in resources ) 
			{
				if ( ! (resource is SRV) ) continue;
				if ( resource.domain != domain ) continue;
				SRV srv = (SRV)resource;
				srvs.Add( new Service(srv.domain, srv.target, srv.port) );
			}
			return (Service[])srvs.ToArray( typeof(Service) );
		}

		public IPAddress[] As( string domain ) 
		{
			ArrayList addresses = new ArrayList();
			foreach ( Resource resource in resources ) 
			{
				if ( ! (resource is A) ) 
				{
					//System.Console.WriteLine( "resource is not A record" );
					continue;
				}
				if ( resource.domain != domain ) 
				{
					//System.Console.WriteLine( "resource '{0}' is not '{1}'", resource.domain, domain );
					continue;
				}
				A a = (A)resource;
				addresses.Add( a.address );
			}
			return (IPAddress[])addresses.ToArray( typeof(IPAddress) );
		}

		public IPAddress[] GetA( string domain ) 
		{
			LSmDNSW.Request request = new LSmDNSW.Request( new LSmDNSW.QueryA(domain) );
			request.Transmit( this );
			GatherResources();
			return As( domain );
		}

		public string[] GetCNAME(string domain)
		{
			LSmDNSW.Request request = new LSmDNSW.Request(new LSmDNSW.QueryCNAME(domain));
			request.Transmit(this);
			GatherResources();
			return CNAMEs(domain);
		}

		public string[] GetAAAA(string domain)
		{
			Request request = new Request(new QueryAAAA(domain));
			request.Transmit(this);
			GatherResources();
			return AAAAs(domain);
		}

		public string[] GetPTR(string domain)
		{
			Request request = new Request(new QueryPTR(domain));
			request.Transmit(this);
			GatherResources();
			return PTRs(domain);
		}
		public Service[] GetSRV( string domain ) 
		{
			Request request = new Request( new QuerySRV(domain) );
			request.Transmit( this );
			GatherResources();
			return SRVs( domain );
		}

		public IPEndPoint[] ResolveServiceName(string service_name)
		{
			ArrayList endpoints = new ArrayList();

			//string[] ptrs1 = GetCNAME(service_name);
			//System.Console.WriteLine("Found {0} PTR RRs for {1}", ptrs1.Length, service_name);
			//string[] ptrs1 = GetAAAA(service_name);
			//System.Console.WriteLine("Found {0} PTR RRs for {1}", ptrs1.Length, service_name);

			string[] ptrs = GetPTR(service_name);
			if (ptrs.Length < 1)
				return null;
			g.Log("Find Device Step 2 : " + ptrs.Length.ToString());

			foreach (string ptr in ptrs)
			{
				Service[] srvs = SRVs(ptr);
				if (srvs.Length == 0)
				{
					srvs = GetSRV(ptr);
				}
				// g.Log("Find Device Step 2 : " + srvs.Length.ToString());
				// System.Console.WriteLine( "Found {0} SRV RRs for {1}", srvs.Length, ptr );

				foreach (Service srv in srvs)
				{
					// System.Console.WriteLine( "SRV: {0}:{1}", srv.target, srv.port );
					IPAddress[] addresses = As(srv.target);

					if (addresses.Length == 0)
					{
						addresses = GetA(srv.target);
					}
					// System.Console.WriteLine( "Found {0} A RRs for {1}", addresses.Length, srv.target );
					foreach (IPAddress address in addresses)
					{
						if (address == null)
							continue;
						// System.Console.WriteLine( "A: {0}", address );
						IPEndPoint endpoint = new IPEndPoint(address, srv.port);
						if (!endpoints.Contains(endpoint))
							endpoints.Add(endpoint);
					}
				}
			}

			return (IPEndPoint[])endpoints.ToArray(typeof(IPEndPoint));
		}

		// PTR 하나만 보내도 IP 얻을수 있음 - 확인 요망 2020-06-29 romee 
		public IPEndPoint[] ResolveServiceName2(string service_name)
		{
			ArrayList endpoints = new ArrayList();

			string[] ptrs = GetPTR(service_name);
			if (ptrs.Length < 1)
				return null;
			g.Log("Find Device Step 1 : " + ptrs.Length.ToString());

			return null;
		}

		public delegate void EventNewDevice(object o);
		public event EventNewDevice OnEventNewDevice;

		public void GetDevice()
		{
			//A
			try 
			{
				foreach (Resource resource in resources)
				{
					if (!(resource is A)) continue;
					A a = (A)resource;

					if (a.address == null) continue;

					string deviceName = "";
					if (a.domain.Split('.')[1] == "local")
						deviceName = a.domain.Split('.')[0];
					if (deviceName == "" || deviceName == null)
						continue;
					//g.Log("A" + a.domain);
					var t1 = gl.danteDevice._DanteDevice.Find(p => p.DeviceName == deviceName);

					if (t1 == null)
					{
						Device t2 = new Device();
						t2.ip = a.address.ToString();
						t2.DeviceName = deviceName;
						t2.srvdomain.Add(a.domain);
						if(a.domain.Split('.')[1] == "local")
							t2.name = a.domain.Split('.')[0];
						OnEventNewDevice?.Invoke(t2);
					}
					else
					{
						var t2 = t1.srvdomain.Find(p1 => p1.Equals(a.domain));
						if (t2 == null)
							t1.srvdomain.Add(a.domain);
						if (a.domain.Split('.')[1] == "local")
							t1.name = a.domain.Split('.')[0];
						if (t1.ip == "169.254.27.248")
						{ }
						if (t1.ip != a.address.ToString())
						{ 
							g.Log("IP Change : " + t1.DeviceName + " : "+ t1.ip + " ==> " + a.address.ToString());
							t1.ip = a.address.ToString();
						}

					}
				}
			}
			catch (Exception e1)
			{
				
			}

			//SRV
			try
			{
				foreach (Resource resource in resources)
				{
					if (!(resource is SRV)) continue;
					SRV a = (SRV)resource;

					//g.Log("SRV:" + a.domain+ ":" + a.target);

					foreach (Device t2 in gl.danteDevice._DanteDevice)
					{
						if (a.target == t2.name + ".local.")
						{
							if (a.domain.Contains("._netaudio-cmc._udp.local."))
							{
								if (a.domain != t2.name + "._netaudio-cmc._udp.local.")
								{ 
									//g.Log("SRV:" + a.domain +":"+ t2.name);
									t2.DanteModelName = t2.name;
									t2.name = a.domain.Split('.')[0];
									g.Log(t2.ip.ToString() + " : " + t2.name + " : " + t2.DanteModelName);
								}
							}
						}
						var t3 = t2.srvdomain.Find(p1 => p1.Equals(a.target));
						if (t3 != null)
						{
							var t4 = t2.ptrdomain.Find(p1 => p1.Equals(a.domain));
							if (t4 == null)
								t2.ptrdomain.Add(a.domain);

							if (a.domain.Contains("id=") != true)
								continue;
							var t5 = t2.domain.Find(p1 => p1.Equals(a.domain));
							if (t5 == null)
							{
								t2.domain.Add(a.domain);
								g.Log(t2.ip.ToString() + " : " + t2.name + " : " + a.domain);

							}

						}
					}
				}
			}
			catch (Exception e1)
			{

			}
			// PTR
			try
			{
				foreach (Resource resource in resources)
				{
					if (!(resource is PTR)) continue;
					PTR a = (PTR)resource;

					//g.Log("PTR:" + a.domain + ":" + a.target);

					foreach (Device t2 in gl.danteDevice._DanteDevice)
					{
						var t3 = t2.ptrdomain.Find(p1 => p1.Equals(a.target));
						//if (a.domain == "_netaudio-arc._udp.local.")
						//	Console.WriteLine(a.target);
						if (t3 != null)
						{
							var t4 = t2.ptrdomain.Find(p1 => p1.Equals(a.domain));
							if (t4 == null)
								t2.ptrdomain.Add(a.domain);

							if (a.domain.Contains("id=") != true)
								continue;
							var t5 = t2.domain.Find(p1 => p1.Equals(a.domain));
							if (t5 == null)
								t2.domain.Add(a.domain);

						}
					}

				}
			}
			catch (Exception e1)
			{

			}
			// TXT
			try
			{
				foreach (Resource resource in resources)
				{
					if (!(resource is TXT)) continue;
					TXT a = (TXT)resource;

					//g.Log("TXT:" + a.domain + ":" + a.txt);
					foreach (Device t2 in gl.danteDevice._DanteDevice)
					{
						var t3 = t2.ptrdomain.Find(p1 => p1.Equals(a.domain));
						if (t3 != null)
						{
							var t4 = t2.txtdomain.Find(p1 => p1.Equals(a.txt));
							if (t4 == null)
								t2.txtdomain.Add(a.txt);

							if (a.domain.Contains("id=") != true)
								continue;
							var t5 = t2.domain.Find(p1 => p1.Equals(a.domain));
							if (t5 == null)
								t2.domain.Add(a.domain);

						}
					}

				}
			}
			catch (Exception e1)
			{

			}
			// resource 
			try
			{
				foreach (Resource resource in resources)
				{
					if (resource is A) continue;
					if (resource is SRV) continue;
					if (resource is PTR) continue;
					if (resource is TXT) continue;
					Resource a = (Resource)resource;

					if (a == null)
						continue;
					if (a.domain == null)
						continue;
					//g.Log("R:" + a.domain);

					foreach (Device t2 in gl.danteDevice._DanteDevice)
					{
						if (a.domain.Contains(t2.name) != true)
							continue;
						if (a.domain.Contains("id=") != true)
							continue;
						var t4 = t2.domain.Find(p1 => p1.Equals(a.domain));
						if (t4 == null)
						{
							t2.domain.Add(a.domain);
							g.Log(t2.ip.ToString() + " : " + t2.name + " : " + a.domain);
						}

					}
				}

			}
			catch (Exception e1)
			{

			}

			resources.Clear();
			/*
			foreach (Device t2 in g.Devices)
			{
				g.Log(t2.ip.ToString() + " : " + t2.name + " : " + t2.domain.Count.ToString());
			}
			*/
		}


		// PTR 하나만 보내도 IP 얻을수 있음 - 확인 요망 2020-06-29 romee 
		public IPEndPoint[] ResolveServiceName3(string service_name)
		{
			string[] ptrs = GetPTR2(service_name);
			return null;
		}

		public string[] GetPTR2(string domain)
		{
			//g.Log("PTR Send.. ");
			Request request = new Request(new QueryPTR(domain));
			request.Transmit(this);
			//StartListening();
			//Thread.Sleep(4000);
			//GatherResources2();
			return null;
		}
	}
	#endregion
}

/* vim: set autoindent expandtab sw=4 : */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simplepa2
{
	/// <summary>
	/// Summary description for Handler1
	/// </summary>
	public class Handler1 : IHttpHandler
	{

		public void ProcessRequest(HttpContext context)
		{
			var name = context.Request["name"];
			if (name != null && name.Length > 0)
				Program.AddClient(name);
		}

		public bool IsReusable
		{
			get { return true; }
		}
	}
}
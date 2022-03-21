using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using Wisej.CodeProject.SignalR;
using static Wisej.CodeProject.DataSet1;

namespace Wisej.CodeProject
{
    public static class g
    {
        public static SignalRClient signalRClient { get; set; } = new SignalRClient();

        internal static void sendSigR(string v)
        {
            SignalRMsg msg1 = new SignalRMsg();
            msg1.message = v;
            if (g.signalRClient.State == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                g.signalRClient.proxy.Invoke("MessageC2S2", msg1);
        }

        internal static void sendSigR(string v, eSignalRMsgType v1, List<AssetsRow> selAsset, List<MusicsRow> selMusic)
        {
            SignalRMsg msg1 = new SignalRMsg();
            msg1.message = v;
            msg1.Msgtype = v1;
            //msg1.assetsRows = selAsset;
            //var t1 = selMusic.Select(p => new { p.MusicId }).ToList();
            var t1 = selMusic.Select(p => new { p.MusicId });
            msg1.musicsRows = t1.Select(p => p.MusicId).ToList();

            var t2 = selAsset.Select(p => new { p.AssetId });
            msg1.assetsRows = t2.Select(p => p.AssetId).ToList();

            try
            { 
                if (g.signalRClient.State == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                    g.signalRClient.proxy.Invoke("MessageC2S2", msg1);
            }
            catch (Exception e1)
            { 
            }
        }
    }
}
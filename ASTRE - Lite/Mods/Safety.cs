using Photon.Pun;
using StupidTemplate.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASTRE.Mods
{
    class Safety
    {
        public static void RPCProtection()
        {
            PhotonNetwork.MaxResendsBeforeDisconnect = int.MaxValue;
            GorillaNot.instance.rpcCallLimit = int.MaxValue;
            GorillaNot.instance.rpcErrorMax = int.MaxValue;
            GorillaNot.instance.logErrorMax = int.MaxValue;
            PhotonNetwork.CleanRpcBufferIfMine(RigManager.GetPhotonViewFromVRRig(GorillaTagger.Instance.offlineVRRig));
            PhotonNetwork.OpCleanActorRpcBuffer(PhotonNetwork.LocalPlayer.ActorNumber);
            PhotonNetwork.OpCleanRpcBuffer(RigManager.GetPhotonViewFromVRRig(GorillaTagger.Instance.offlineVRRig));
            PhotonNetwork.RemoveBufferedRPCs(GorillaTagger.Instance.myVRRig.ViewID, null, null);
            PhotonNetwork.RemoveBufferedRPCs();
            PhotonNetwork.RemoveRPCs(PhotonNetwork.LocalPlayer);
            PhotonNetwork.RemoveRPCsInGroup(int.MaxValue);
            PhotonNetwork.SendAllOutgoingCommands();
            GorillaNot.instance.OnPlayerLeftRoom(PhotonNetwork.LocalPlayer);
        }

        public static void FlushRPCs()
        {
            PhotonNetwork.CleanRpcBufferIfMine(RigManager.GetPhotonViewFromVRRig(GorillaTagger.Instance.offlineVRRig));
            PhotonNetwork.OpCleanActorRpcBuffer(PhotonNetwork.LocalPlayer.ActorNumber);
            PhotonNetwork.OpCleanRpcBuffer(RigManager.GetPhotonViewFromVRRig(GorillaTagger.Instance.offlineVRRig));
            PhotonNetwork.RemoveBufferedRPCs(GorillaTagger.Instance.myVRRig.ViewID, null, null);
            PhotonNetwork.RemoveBufferedRPCs();
            PhotonNetwork.RemoveRPCs(PhotonNetwork.LocalPlayer);
            PhotonNetwork.RemoveRPCsInGroup(int.MaxValue);
            PhotonNetwork.SendAllOutgoingCommands();
            GorillaNot.instance.OnPlayerLeftRoom(PhotonNetwork.LocalPlayer);
        }
    }
}

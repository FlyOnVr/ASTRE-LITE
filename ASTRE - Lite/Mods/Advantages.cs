using ASTRE.Classes;
using Photon.Pun;
using StupidTemplate.Classes;
using StupidTemplate.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;

namespace ASTRE.Mods
{
    class Advantages
    {
        public static void TagGun()
        {
            if (PhotonNetwork.InRoom)
            {
                GunTemplate.StartBothGuns(() =>
                {
                    GorillaTagger.Instance.rightHandTransform.position = GunTemplate.spherepointer.transform.position;
                    GorillaTagger.Instance.offlineVRRig.enabled = false;
                    GorillaTagger.Instance.offlineVRRig.transform.position = GunTemplate.LockedPlayer.transform.position;
                    GorillaTagger.Instance.offlineVRRig.enabled = true;
                }, false);
            }
        }

        public static void TagSelf()
        {
            foreach (GorillaTagManager gorillaTagManager in UnityEngine.Object.FindObjectsOfType<GorillaTagManager>())
            {
                foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                {
                    if (vrrig.mainSkin.material.name.Contains("fected"))
                    {
                        if (!gorillaTagManager.currentInfected.Contains(PhotonNetwork.LocalPlayer))
                        {
                            GorillaTagger.Instance.offlineVRRig.enabled = false;
                            GorillaTagger.Instance.offlineVRRig.transform.position = vrrig.rightHandTransform.position;
                        }
                        else
                        {
                            GorillaTagger.Instance.offlineVRRig.enabled = true;
                        }
                    }
                }
            }
        }

        public static void TagAll()
        {
            if (ControllerInputPoller.instance.rightGrab || Mouse.current.rightButton.isPressed)
            {
                VRRig component = GorillaGameManager.instance.FindPlayerVRRig(PhotonNetwork.PlayerListOthers[UnityEngine.Random.Range(0, 10)]).gameObject.GetComponent<VRRig>();
                if (!component.mainSkin.material.name.Contains("fected"))
                {
                    if (!GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("fected"))
                        return;

                    GorillaTagger.Instance.offlineVRRig.enabled = false;
                    GorillaTagger.Instance.offlineVRRig.transform.position = component.headMesh.transform.position + new UnityEngine.Vector3(0.0f, 1f, 0.0f);
                    GorillaTagger.Instance.rightHandTransform.position = component.headMesh.transform.position;
                    GorillaTagger.Instance.leftHandTransform.position = component.headMesh.transform.position;
                    GorillaTagger.Instance.offlineVRRig.rightHandTransform.position = component.headMesh.transform.position;
                    GorillaTagger.Instance.offlineVRRig.leftHandTransform.position = component.headMesh.transform.position;
                    Safety.RPCProtection();
                }
                else
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = true;
                }
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
    }
}

using ASTRE.Classes;
using Photon.Pun;
using StupidTemplate.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

namespace ASTRE.Mods
{
    class Fun
    {

        public static void BubblesSpam()
        {
            GameObject gameObject = GameObject.Find("Player Objects/Player VR Controller/GorillaPlayer/TurnParent/Main Camera/UnderwaterVisualEffects/UnderwaterParticleEffects/UnderwaterBubbles");
            if (ControllerInputPoller.instance.rightGrab || Mouse.current.rightButton.isPressed)
            {
                for (int i = 0; i < 4; i++)
                {
                    GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject);
                    gameObject2.SetActive(true);
                    gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
                    gameObject2.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                    UnityEngine.Object.Destroy(gameObject2, 2f);
                }
            }
        }

        public static void CaseohMonke()
        {
            VRRig offlineVRRig = GorillaTagger.Instance.offlineVRRig;
            Color playerColor = offlineVRRig.playerColor;
            GameObject gameObject = GameObject.CreatePrimitive(0);
            gameObject.transform.position = offlineVRRig.transform.position + offlineVRRig.transform.forward * 0.2f + Vector3.down * 0.3f;
            gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            gameObject.transform.LookAt(offlineVRRig.transform.transform);
            gameObject.GetComponent<Renderer>().material = GorillaTagger.Instance.offlineVRRig.mainSkin.material;
            gameObject.GetComponent<Renderer>().material.color = GorillaTagger.Instance.offlineVRRig.mainSkin.material.color;
            UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
            UnityEngine.Object.Destroy(gameObject.GetComponent<Collider>());
        }

        public static void BunnyHop()
        {
            Physics.Raycast(GorillaTagger.Instance.bodyCollider.transform.position - new Vector3(0f, 0.2f, 0f), Vector3.down, out var Ray, 512);

            if (Ray.distance < 0.15f)
            {
                GorillaTagger.Instance.bodyCollider.attachedRigidbody.velocity = new Vector3(GorillaTagger.Instance.bodyCollider.attachedRigidbody.velocity.x, (GorillaLocomotion.GTPlayer.Instance.jumpMultiplier * 2.727272727f), GorillaTagger.Instance.bodyCollider.attachedRigidbody.velocity.z);
            }
        }

        public static void FixRig()
        {
            GorillaTagger.Instance.offlineVRRig.enabled = true;
        }

        public static void Ghostmonke()
        {
            {
                GorillaTagger.Instance.offlineVRRig.enabled = !ghostMonke;
                if (ControllerInputPoller.instance.rightControllerSecondaryButton || Mouse.current.rightButton.isPressed && !lastHit)
                {
                    ghostMonke = !ghostMonke;
                }
                lastHit = ControllerInputPoller.instance.rightControllerSecondaryButton;
            }
        }
        public static void InvisMonke()
        {
            {
                if (invisMonke)
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = false;
                    GorillaTagger.Instance.offlineVRRig.transform.position = new Vector3(9999f, 9999f, 9999f);
                }
                else
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = true;
                }
                if (ControllerInputPoller.instance.rightControllerSecondaryButton && !lastHit2)
                {
                    invisMonke = !invisMonke;
                }
                lastHit2 = ControllerInputPoller.instance.rightControllerSecondaryButton;
            }
        }
        public static bool ghostMonke = false;
        public static bool invisMonke = false;
        public static bool lastHit2;
        public static bool lastHit;

        public static void RigGun()
        {
            GunTemplate.StartBothGuns(() =>
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = GunTemplate.spherepointer.transform.position + new Vector3(0f, 1f, 0f);
            }, false);
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }

        public static void LongArms()
        {
            GorillaLocomotion.GTPlayer.Instance.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }
        public static void FixLongArms()
        {
            GorillaLocomotion.GTPlayer.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
        }

        public static void TpToStump()
        {
            GameObject.Find("Player Objects/Player VR Controller/GorillaPlayer").GetComponent<ControllerInputPoller>();
            if (!GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom").activeSelf)
                return;
            if (ControllerInputPoller.instance.rightControllerPrimaryButton || Mouse.current.rightButton.isPressed)
            {
                foreach (Collider collider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    collider.enabled = false;
                GorillaLocomotion.GTPlayer.Instance.transform.position = new Vector3(-66.4848f, 11.8871f, -82.6619f);
            }
            else
            {
                foreach (Collider collider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    collider.enabled = true;
            }
        }

        public static void ReportAll()
        {
            GorillaPlayerScoreboardLine[] ScoreBoardLine = UnityEngine.Object.FindObjectsOfType<GorillaPlayerScoreboardLine>();
            foreach (GorillaPlayerScoreboardLine ReportLine in ScoreBoardLine)
            {
                if (ReportLine.linePlayer != null)
                {
                    ReportLine.PressButton(true, GorillaPlayerLineButton.ButtonType.Toxicity);
                }
            }
        }

        public static void MuteAll()
        {
            GorillaPlayerScoreboardLine[] ScoreBoardLine = UnityEngine.Object.FindObjectsOfType<GorillaPlayerScoreboardLine>();
            foreach (GorillaPlayerScoreboardLine MuteLine in ScoreBoardLine)
            {
                if (MuteLine.linePlayer != null)
                {
                    MuteLine.PressButton(true, GorillaPlayerLineButton.ButtonType.Mute);
                    MuteLine.muteButton.isOn = true;
                    MuteLine.muteButton.UpdateColor();
                }
            }
        }

        public static void UnMuteAll()
        {
            GorillaPlayerScoreboardLine[] ScoreBoardLine = UnityEngine.Object.FindObjectsOfType<GorillaPlayerScoreboardLine>();
            foreach (GorillaPlayerScoreboardLine MuteLine in ScoreBoardLine)
            {
                if (MuteLine.linePlayer != null)
                {
                    MuteLine.PressButton(true, GorillaPlayerLineButton.ButtonType.Mute);
                    MuteLine.muteButton.isOn = false;
                    MuteLine.muteButton.UpdateColor();
                }
            }
        }

        public static void ReportGun()
        {
            GunTemplate.StartBothGuns(() =>
            {
                GorillaPlayerScoreboardLine[] ScoreBoardLine = UnityEngine.Object.FindObjectsOfType<GorillaPlayerScoreboardLine>();
                foreach (GorillaPlayerScoreboardLine ReportLine in ScoreBoardLine)
                {
                    if (ReportLine.linePlayer == RigManager.GetPlayerFromVRRig(GunTemplate.LockedPlayer))
                    {
                        ReportLine.PressButton(true, GorillaPlayerLineButton.ButtonType.Toxicity);
                    }
                }
            }, false);
        }


        public static void MuteGun()
        {
            GunTemplate.StartBothGuns(() =>
            {
                GorillaPlayerScoreboardLine[] ScoreBoardLine = UnityEngine.Object.FindObjectsOfType<GorillaPlayerScoreboardLine>();
                foreach (GorillaPlayerScoreboardLine MuteLine in ScoreBoardLine)
                {
                    if (MuteLine.linePlayer == RigManager.GetPlayerFromVRRig(GunTemplate.LockedPlayer))
                    {
                        MuteLine.PressButton(true, GorillaPlayerLineButton.ButtonType.Mute);
                        MuteLine.muteButton.isOn = true;
                        MuteLine.muteButton.UpdateColor();
                    }
                }
            }, false);
        }

        public static void UnMuteGun()
        {
            GunTemplate.StartBothGuns(() =>
            {
                GorillaPlayerScoreboardLine[] ScoreBoardLine = UnityEngine.Object.FindObjectsOfType<GorillaPlayerScoreboardLine>();
                foreach (GorillaPlayerScoreboardLine MuteLine in ScoreBoardLine)
                {
                    if (MuteLine.linePlayer == RigManager.GetPlayerFromVRRig(GunTemplate.LockedPlayer))
                    {
                        MuteLine.PressButton(true, GorillaPlayerLineButton.ButtonType.Mute);
                        MuteLine.muteButton.isOn = false;
                        MuteLine.muteButton.UpdateColor();
                    }
                }
            }, false);
        }

        public static void MuteAllMusic()
        {
            foreach (SoundPostMuteButton muteButton in UnityEngine.Object.FindObjectsOfType<SoundPostMuteButton>())
            {
                muteButton.ButtonActivation();
            }
        }
    }
}

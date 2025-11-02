using ASTRE.Classes;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ASTRE.Mods
{
    class Movement
    {
        public static GameObject leftPlatform;
        public static GameObject rightPlatform;
        public static void Platforms()
        {
            PlatformStuff(ref leftPlatform, ControllerInputPoller.instance.leftGrab, GorillaTagger.Instance.leftHandTransform, false);
            PlatformStuff(ref rightPlatform, ControllerInputPoller.instance.rightGrab, GorillaTagger.Instance.rightHandTransform, false);
        }
        public static void InvisPlatforms()
        {
            PlatformStuff(ref leftPlatform, ControllerInputPoller.instance.leftGrab, GorillaTagger.Instance.leftHandTransform, true);
            PlatformStuff(ref rightPlatform, ControllerInputPoller.instance.rightGrab, GorillaTagger.Instance.rightHandTransform, true);
        }
        public static void PlatGun()
        {
            GunTemplate.StartBothGuns(() =>
            {
                GameObject platform = GameObject.CreatePrimitive(PrimitiveType.Cube);
                UnityEngine.Object.Destroy(platform.GetComponent<BoxCollider>());
                platform.GetComponent<Renderer>().material.color = UnityEngine.Color.blue;
                platform.transform.localScale = new UnityEngine.Vector3(0.28f, 0.015f, 0.28f);
                platform.transform.position = GunTemplate.spherepointer.transform.position;
                UnityEngine.Object.Destroy(platform, 1f);
                PhotonNetwork.RaiseEvent(69, new object[1] { platform.transform.position }, new RaiseEventOptions { Receivers = ReceiverGroup.Others }, SendOptions.SendReliable);

            }, false);
        }
        public static void PlatformSpam()
        {
            if (ControllerInputPoller.instance.leftGrab || Mouse.current.rightButton.isPressed)
            {
                GameObject platform = GameObject.CreatePrimitive(PrimitiveType.Cube);
                UnityEngine.Object.Destroy(platform.GetComponent<BoxCollider>());
                platform.GetComponent<Renderer>().material.color = UnityEngine.Color.blue;
                platform.transform.localScale = new UnityEngine.Vector3(0.28f, 0.015f, 0.28f);
                platform.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                UnityEngine.Object.Destroy(platform, 1f);
                PhotonNetwork.RaiseEvent(69, new object[1] { platform.transform.position }, new RaiseEventOptions { Receivers = ReceiverGroup.Others }, SendOptions.SendReliable);
            }
            if (ControllerInputPoller.instance.rightGrab || Mouse.current.rightButton.isPressed)
            {
                GameObject platform = GameObject.CreatePrimitive(PrimitiveType.Cube);
                UnityEngine.Object.Destroy(platform.GetComponent<BoxCollider>());
                platform.GetComponent<Renderer>().material.color = UnityEngine.Color.blue;
                platform.transform.localScale = new UnityEngine.Vector3(0.28f, 0.015f, 0.28f);
                platform.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                UnityEngine.Object.Destroy(platform, 1f);
                PhotonNetwork.RaiseEvent(69, new object[1] { platform.transform.position }, new RaiseEventOptions { Receivers = ReceiverGroup.Others }, SendOptions.SendReliable);
            }
        }
        public static void PlatformStuff(ref GameObject platform, bool isGrabbing, Transform controllerTransform, bool InvisPlat)
        {
            if (isGrabbing)
            {
                if (platform == null)
                {
                    platform = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    platform.transform.localScale = new UnityEngine.Vector3(0.28f, 0.015f, 0.28f);
                    platform.transform.position = controllerTransform.position + new UnityEngine.Vector3(0f, -0.02f, 0f);
                    platform.transform.rotation = controllerTransform.rotation * UnityEngine.Quaternion.Euler(0f, 0f, -90f);
                    platform.GetComponent<Renderer>().material.color = UnityEngine.Color.blue;
                    platform.AddComponent<GorillaSurfaceOverride>().overrideIndex = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/sky jungle entrance 2/ElevatorClouds/Cloud_Platform_001 Variant").GetComponent<GorillaSurfaceOverride>().overrideIndex;

                    if (InvisPlat == true)
                    {
                        platform.GetComponent<Renderer>().enabled = false;
                    }
                }
            }
            else if (platform != null)
            {
                GameObject.Destroy(platform);
                platform = null;
            }
        }

        public static void Noclip()
        {
            foreach (MeshCollider m in Resources.FindObjectsOfTypeAll<MeshCollider>())
            {
                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f || Mouse.current.rightButton.isPressed)
                {
                    m.enabled = false;
                }
                else
                {
                    m.enabled = true;
                }
            }
        }

        public static void NoGravity()
        {
            Physics.gravity = Vector3.zero;
        }

        public static void HighGravity()
        {
            Physics.gravity = new Vector3(0f, -10f, 0f);
        }
        public static void FixGrav()
        {
            Physics.gravity = new Vector3(0f, -9.81f, 0f);
        }
        public static void ForceTagFreeze()
        {
            GorillaLocomotion.GTPlayer.Instance.disableMovement = true;
        }

        public static void NoTagFreeze()
        {
            GorillaLocomotion.GTPlayer.Instance.disableMovement = false;
        }

        public static void Fly()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton || Mouse.current.rightButton.isPressed)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position += GorillaLocomotion.GTPlayer.Instance.headCollider.transform.forward * Time.deltaTime * 10f;
                GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>().velocity = UnityEngine.Vector3.zero;
            }
        }

        public static void TPGun()
        {
            GunTemplate.StartBothGuns(() =>
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position = GunTemplate.spherepointer.transform.position;
                GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>().velocity = UnityEngine.Vector3.zero;
            }, false);
        }

        public static void WallWalk()
        {
            if (ControllerInputPoller.instance.rightGrab || Mouse.current.rightButton.isPressed)
            {
                GorillaLocomotion.GTPlayer.Instance.bodyCollider.attachedRigidbody.AddForce(GorillaLocomotion.GTPlayer.Instance.bodyCollider.transform.right * (Time.deltaTime * (3f / Time.deltaTime)), ForceMode.Acceleration);
            }

            if (ControllerInputPoller.instance.leftGrab || Mouse.current.leftButton.isPressed)
            {
                GorillaLocomotion.GTPlayer.Instance.bodyCollider.attachedRigidbody.AddForce(GorillaLocomotion.GTPlayer.Instance.bodyCollider.transform.right * (Time.deltaTime * (-3f / Time.deltaTime)), ForceMode.Acceleration);
            }

            if (ControllerInputPoller.instance.rightGrab || Mouse.current.rightButton.isPressed && ControllerInputPoller.instance.leftGrab || Mouse.current.leftButton.isPressed)
            {
                GorillaLocomotion.GTPlayer.Instance.bodyCollider.attachedRigidbody.AddForce(GorillaLocomotion.GTPlayer.Instance.bodyCollider.transform.forward * (Time.deltaTime * (3f / Time.deltaTime)), ForceMode.Acceleration);
            }
        }

        public static void UpAndDown()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f || Mouse.current.rightButton.isPressed)
            {
                GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>().AddForce(new UnityEngine.Vector3(0f, 20f, 0f), ForceMode.Impulse);
            }
            else if (ControllerInputPoller.instance.leftControllerIndexFloat > 0.1f || Mouse.current.leftButton.isPressed)
            {
                GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>().AddForce(new UnityEngine.Vector3(0f, -20f, 0f), ForceMode.Impulse);
            }
        }

        public static void IronMonke()
        {
            if (ControllerInputPoller.instance.rightGrab || Mouse.current.rightButton.isPressed)
            {
                GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>().AddForce(new UnityEngine.Vector3(20f * GorillaTagger.Instance.rightHandTransform.right.x, 20f * GorillaTagger.Instance.rightHandTransform.right.y, 20f * GorillaTagger.Instance.rightHandTransform.right.z), ForceMode.Acceleration);
            }
            else if (ControllerInputPoller.instance.leftGrab || Mouse.current.leftButton.isPressed)
            {
                GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>().AddForce(new UnityEngine.Vector3(-20f * GorillaTagger.Instance.rightHandTransform.right.x, -20f * GorillaTagger.Instance.rightHandTransform.right.y, -20f * GorillaTagger.Instance.rightHandTransform.right.z), ForceMode.Acceleration);
            }
        }

        public static void CarMonke()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f || Mouse.current.rightButton.isPressed)
            {
                GorillaLocomotion.GTPlayer.Instance.bodyCollider.attachedRigidbody.velocity += GorillaLocomotion.GTPlayer.Instance.bodyCollider.transform.forward * Time.deltaTime * 22f;
            }
            else if (ControllerInputPoller.instance.leftControllerIndexFloat > 0.1f || Mouse.current.leftButton.isPressed)
            {
                GorillaLocomotion.GTPlayer.Instance.bodyCollider.attachedRigidbody.velocity -= GorillaLocomotion.GTPlayer.Instance.bodyCollider.transform.forward * Time.deltaTime * 22f;
            }
        }

        public static void SpeedBoost()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 8f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 8f;
        }
        public static void mosaboost()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 6f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 6f;
        }

        public static void superspeed()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 11f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 11f;
        }

        public static void SlideControl()
        {
            GorillaLocomotion.GTPlayer.Instance.slideControl = 9999f;
        }
        public static void SlideControlfix()
        {
            GorillaLocomotion.GTPlayer.Instance.slideControl = 1f;
        }
    }
}

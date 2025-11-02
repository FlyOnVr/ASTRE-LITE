using Photon.Pun;
using StupidTemplate.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace ASTRE.Mods
{
    class Visuals
    {
        public static void Beacons()
        {
            if (PhotonNetwork.CurrentRoom != null)
            {
                foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                {
                    if (vrrig != GorillaTagger.Instance.offlineVRRig)
                    {
                        GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                        UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
                        UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
                        UnityEngine.Object.Destroy(gameObject.GetComponent<Collider>());
                        gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", UnityEngine.Color.green);
                        gameObject.transform.rotation = Quaternion.identity;
                        gameObject.transform.localScale = new Vector3(0.04f, 200f, 0.04f);
                        gameObject.transform.position = vrrig.transform.position;
                        gameObject.GetComponent<MeshRenderer>().material = vrrig.mainSkin.material;
                        UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
                    }
                }
            }
        }

        public static void Tracers()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig != GorillaTagger.Instance.offlineVRRig)
                {
                    GameObject lineObject = new GameObject("Line");


                    LineRenderer lineRenderer = lineObject.AddComponent<LineRenderer>();
                    lineRenderer.material.shader = Shader.Find("GorillaTag/UberShader");
                    lineRenderer.material.shader = Shader.Find("GorillaTag/UberShader");
                    lineRenderer.startWidth = 0.01f;
                    lineRenderer.endWidth = 0.01f;
                    lineRenderer.positionCount = 2;
                    lineRenderer.useWorldSpace = true;
                    lineRenderer.SetPosition(0, GorillaTagger.Instance.rightHandTransform.position);
                    lineRenderer.SetPosition(1, vrrig.transform.position);
                    lineRenderer.material = vrrig.mainSkin.material;
                    UnityEngine.Object.Destroy(lineObject, Time.deltaTime);
                }
            }
        }

        public static void RGBSnowballs()
        {
            if (cooldown2 < Time.time)
            {
                foreach (SnowballThrowable snowballThrowable in UnityEngine.Object.FindObjectsOfType<SnowballThrowable>())
                {
                    bool flag2 = !snowballThrowable.randomizeColor;
                    if (flag2)
                    {
                        snowballThrowable.randomizeColor = true;
                    }
                }
                Snowball = Time.time + 0.1f;
            }
        }

        public static void FixRGBSnowballs()
        {
            if (cooldown2 < Time.time)
            {
                foreach (SnowballThrowable snowballThrowable in UnityEngine.Object.FindObjectsOfType<SnowballThrowable>())
                {
                    bool flag2 = !snowballThrowable.randomizeColor;
                    if (flag2)
                    {
                        snowballThrowable.randomizeColor = false;
                    }
                }
                Snowball = Time.time + 0.1f;
            }
        }

        public static void BoxESP()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig != GorillaTagger.Instance.offlineVRRig)
                {
                    Color thecolor = vrrig.playerColor;
                    GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    box.transform.position = vrrig.transform.position;
                    UnityEngine.Object.Destroy(box.GetComponent<BoxCollider>());
                    box.transform.localScale = new Vector3(0.8f, 0.8f, 0f);
                    box.transform.LookAt(GorillaTagger.Instance.headCollider.transform.position);
                    box.GetComponent<Renderer>().material.color = Color.blue;
                    box.GetComponent<Renderer>().material.color = thecolor;
                    UnityEngine.Object.Destroy(box, Time.deltaTime);
                }
            }
        }
        public static float Snowball = 0.1f;
        public static float cooldown2 = 0.1f;

        public static void Chams()
        {
            foreach (VRRig rigs in GorillaParent.instance.vrrigs)
            {
                if (rigs.mainSkin.material.name.Contains("fected"))
                {
                    rigs.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
                    rigs.mainSkin.material.color = new Color32(255, 0, 0, 255);
                    GorillaTagger.Instance.offlineVRRig.mainSkin.material.shader = Shader.Find("GorillaTag/UberShader");
                    GorillaTagger.Instance.offlineVRRig.mainSkin.material.color = GorillaTagger.Instance.offlineVRRig.playerColor;
                }
                else
                {
                    rigs.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
                    rigs.mainSkin.material.color = new Color32(0, 255, 0, 255);
                    GorillaTagger.Instance.offlineVRRig.mainSkin.material.shader = Shader.Find("GorillaTag/UberShader");
                    GorillaTagger.Instance.offlineVRRig.mainSkin.material.color = GorillaTagger.Instance.offlineVRRig.playerColor;
                }
            }
        }


        public static void dischams()
        {
            foreach (VRRig rigs in GorillaParent.instance.vrrigs)
            {
                rigs.mainSkin.material.shader = Shader.Find("GorillaTag/UberShader");
                rigs.mainSkin.material.color = rigs.playerColor;
                GorillaTagger.Instance.offlineVRRig.mainSkin.material.shader = Shader.Find("GorillaTag/UberShader");
                GorillaTagger.Instance.offlineVRRig.mainSkin.material.color = GorillaTagger.Instance.offlineVRRig.playerColor;
            }
        }
    }
}

using BepInEx;
using TMPro;
using UnityEngine;

namespace StupidTemplate
{
    [BepInPlugin("com.yourname.gtag.nametags", "Mod name", "1.0.0")]
    public class StumpText : BaseUnityPlugin
    {
        private TextMeshPro tmp;

        private void Start()
        {
            GameObject textObj = new GameObject("StumpText");

            textObj.transform.position = new Vector3(-66.9225f, 12.1325f, -82.5845f); //stump position

            tmp = textObj.AddComponent<TextMeshPro>();
            tmp.text = $"Ty for using ASTRE V{PluginInfo.Version}"; //put your text here
            tmp.fontSize = 2f; //change font size here
            tmp.alignment = TextAlignmentOptions.Center;
            tmp.color = Color.red; //change text color here
        }

        private void Update()
        {
            // makes the text follow you
            if (Camera.main != null && tmp != null)
            {
                tmp.transform.rotation = Quaternion.LookRotation(tmp.transform.position - Camera.main.transform.position);
            }
        }
    }
}
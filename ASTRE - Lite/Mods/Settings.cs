using AetherTemp.Menu;
using StupidTemplate.Classes;
using StupidTemplate.Menu;
using StupidTemplate.Patches;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace ASTRE.Mods
{
    class Settingss
    {
        public static void Save()
        {
            List<String> list = new List<String>();
            foreach (ButtonInfo[] button in Buttons.buttons)
            {
                foreach (ButtonInfo button2 in button)
                {
                    if (button2.enabled == true)
                    {
                        list.Add(button2.buttonText + button2.overlapText);
                    }
                }

            }
            System.IO.Directory.CreateDirectory("ASTRE");
            System.IO.File.WriteAllLines("ASTRE\\Saved_Mods.txt", list);
        }

        public static void Load()
        {
            String[] thing = System.IO.File.ReadAllLines("ASTRE\\Saved_Mods.txt");
            foreach (String thing2 in thing)
            {
                foreach (ButtonInfo[] button in Buttons.buttons)
                {
                    foreach (ButtonInfo button2 in button)
                    {
                        if (button2.buttonText + button2.overlapText == thing2)
                        {
                            button2.enabled = true;
                        }
                    }
                }
            }
        }
        public static int t = 0;
        public static void ChangeMenuTheme()
        {
            t++;
            if (t > 11)
            {
                t = 0;
            }

            if (t == 0)
            {
                Main.menuBackground.GetComponent<Renderer>().material.color = new Color(101f / 255f, 158f / 255f, 105f / 255f, 1f);
                Main.OutlineColor = new Color(0.054f, 0.054f, 0.054f);
                Main.GetIndex("Change Theme").overlapText = "Theme : Default";
            }
            if (t == 1)
            {
                Main.menuBackground.GetComponent<Renderer>().material.color = new Color32(11, 34, 117, 255);
                Main.OutlineColor = new Color32(48, 93, 221, 255);
                Main.GetIndex("Change Theme").overlapText = "Theme : Blue";
            }
            if (t == 2)
            {
                Main.menuBackground.GetComponent<Renderer>().material.color = Color.black;
                Main.OutlineColor = Color.grey;
                Main.GetIndex("Change Theme").overlapText = "Theme : Black";
            }
            if (t == 3)
            {
                Main.menuBackground.GetComponent<Renderer>().material.color = Color.grey;
                Main.OutlineColor = Color.black;
                Main.GetIndex("Change Theme").overlapText = "Theme : Grey";
            }
            if (t == 4)
            {
                Main.menuBackground.GetComponent<Renderer>().material.color = Color.green;
                Main.OutlineColor = Color.black;
                Main.GetIndex("Change Theme").overlapText = "Theme : Green";
            }
            if (t == 5)
            {
                Main.menuBackground.GetComponent<Renderer>().material.color = new Color32(255, 192, 203, 255);
                Main.OutlineColor = new Color32(219, 112, 147, 255);
                Main.GetIndex("Change Theme").overlapText = "Theme : Pink";
            }
            if (t == 6)
            {
                Main.menuBackground.GetComponent<Renderer>().material.color = new Color32(74, 0, 149, 255);
                Main.OutlineColor = new Color32(207, 159, 255, 255);
                Main.GetIndex("Change Theme").overlapText = "Theme : Purple";
            }
            if (t == 7)
            {
                Main.menuBackground.GetComponent<Renderer>().material.color = new Color32(255, 255, 143, 255);
                Main.OutlineColor = new Color32(0, 0, 0, 255);
                Main.GetIndex("Change Theme").overlapText = "Theme : Yellow";
            }
            if (t == 8)
            {
                Main.menuBackground.GetComponent<Renderer>().material.color = new Color32(0, 158, 255, 255);
                Main.OutlineColor = new Color32(0, 0, 0, 255);
                Main.GetIndex("Change Theme").overlapText = "Theme : Light Blue";
            }
            if (t == 9)
            {
                Main.menuBackground.GetComponent<Renderer>().material.color = new Color32(255, 135, 0, 255);
                Main.OutlineColor = new Color32(0, 0, 0, 255);
                Main.GetIndex("Change Theme").overlapText = "Theme : Orange";
            }
            if (t == 10)
            {
                Main.menuBackground.GetComponent<Renderer>().material.color = new Color32(120, 255, 0, 255);
                Main.OutlineColor = new Color32(0, 0, 0, 255);
                Main.GetIndex("Change Theme").overlapText = "Theme : Lime";
            }
            if (t == 11)
            {
                Main.menuBackground.GetComponent<Renderer>().material.color = new Color32(0, 248, 255, 255);
                Main.OutlineColor = new Color32(0, 0, 0, 255);
                Main.GetIndex("Change Theme").overlapText = "Theme : Aqua";
            }
        }
    }
}

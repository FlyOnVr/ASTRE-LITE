using System;
using UnityEngine;

namespace StupidTemplate.Classes
{
    public class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
                
                new GradientColorKey(
                    new Color32(60, 15, 15, 255),
                    0f 
                )
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;

    }
}

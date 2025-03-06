using System;
using UnityEngine;

namespace StupidTemplate.Classes
{
    public class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(new Color(0.858f, 0.858f, 1f), 1f),
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}

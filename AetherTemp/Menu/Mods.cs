using System;
using System.Collections.Generic;
using System.Text;
using BepInEx;
using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;

namespace StupidTemplate.Menu
{
    class mods
    {
        public static void Disconnect()
        {
            PhotonNetwork.Disconnect();
        }

        public static void orbitfast()
        {
            Main.orbitSpeed = 2f;
        }

        public static void orbitnormalspeed()
        {
            Main.orbitSpeed = 1f;
        }

        public static void orbitslow()
        {
            Main.orbitSpeed = 0.5f;
        }

        public static void orbitfar()
        {
            Main.orbitRadius = 1.5f;
        }

        public static void orbitnormal()
        {
            Main.orbitRadius = 1f;
        }

        public static void orbitclose()
        {
            Main.orbitRadius = 0.5f;
        }
        public static void placeholder()
        {

        }
    }
}

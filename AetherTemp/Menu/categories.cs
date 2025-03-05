using static StupidTemplate.Menu.Main;
using static StupidTemplate.Settings;

namespace AetherTemp.Menu
{
    internal class SettingsMods
    {
        public static void EnterSettings()
        {
            buttonsType = 0;
        }

        public static void MenuSettings()
        {
            buttonsType = 1;
        }

        public static void advantages()
        {
            buttonsType = 2;
        }

        public static void movement()
        {
            buttonsType = 3;
        }

        public static void visuals()
        {
            buttonsType = 4;
        }

        public static void overpowered()
        {
            buttonsType = 5;
        }

        public static void safety()
        {
            buttonsType = 6;
        }

        public static void fun()
        {
            buttonsType = 7;
        }

        public static void guardian()
        {
            buttonsType = 8;
        }

        public static void RightHand()
        {
            rightHanded = true;
        }

        public static void LeftHand()
        {
            rightHanded = false;
        }

        public static void EnableFPSCounter()
        {
            fpsCounter = true;
        }

        public static void DisableFPSCounter()
        {
            fpsCounter = false;
        }

        public static void EnableNotifications()
        {
            disableNotifications = false;
        }

        public static void DisableNotifications()
        {
            disableNotifications = true;
        }

        public static void EnableDisconnectButton()
        {
            disconnectButton = true;
        }

        public static void DisableDisconnectButton()
        {
            disconnectButton = false;
        }
    }
}

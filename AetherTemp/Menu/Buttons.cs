using StupidTemplate.Classes;
using StupidTemplate.Menu;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace AetherTemp.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "advantages", method =() => SettingsMods.advantages(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "movement", method =() => SettingsMods.movement(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
                new ButtonInfo { buttonText = "advantages", method =() => SettingsMods.advantages(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "safety", method =() => SettingsMods.safety(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
                new ButtonInfo { buttonText = "fun", method =() => SettingsMods.fun(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "guardian", method =() => SettingsMods.guardian(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "orbit slow speed", method =() => mods.orbitslow(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "orbit normmal speed", method =() => mods.orbitnormal(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "orbit fast speed", method =() => mods.orbitfast(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "orbit far", method =() => mods.orbitfar(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "orbit normmal", method =() => mods.orbitnormal(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "orbit close", method =() => mods.orbitclose(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right/Left Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Advantages
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // Movement
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // visuals
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // overpowered
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // safety
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // fun
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // guardian
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },




            //always keep this at the bottom if you add another tab (by going to categories) make sure you put that section above this one:

             new ButtonInfo[] { 
                new ButtonInfo { buttonText = "Disconnect", method =() => mods.Disconnect(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },

             new ButtonInfo[] {
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },

        };
    }
}

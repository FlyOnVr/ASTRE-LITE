using GorillaTag.Cosmetics.Summer;
using StupidTemplate.Classes;
using StupidTemplate.Menu;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;
using UnityEngine;
using GorillaTag.Cosmetics;
using StupidTemplate;
using ASTRE.Mods;


namespace AetherTemp.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "★ settings ★", method =() => SettingsMods.MainSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "★ advantages ★", method =() => SettingsMods.advantages(), isTogglable = false, toolTip = "Opens the advantages page for the menu."},
                new ButtonInfo { buttonText = "★ visuals ★", method =() => SettingsMods.visuals(), isTogglable = false, toolTip = "Opens the visuals page for the menu."},
                new ButtonInfo { buttonText = "★ movement ★" , method =() => SettingsMods.movement(), isTogglable = false, toolTip = "Opens the movement page for the menu."},
                new ButtonInfo { buttonText = "★ overpowered ★", method =() => SettingsMods.overpowered(), isTogglable = false, toolTip = "Opens the overpowered page for the menu."},
                new ButtonInfo { buttonText = "★ safety ★", method =() => SettingsMods.safety(), isTogglable = false, toolTip = "Opens the safety page for the menu."},
                new ButtonInfo { buttonText = "★ fun ★", method =() => SettingsMods.fun(), isTogglable = false, toolTip = "Opens the fun page for the menu."},
                new ButtonInfo { buttonText = "★ experimental ★", method =() => SettingsMods.guardian(), isTogglable = false, toolTip = "Opens the guardian page for the menu."},
            },

            new ButtonInfo[] { // Main Settings
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home for the menu."},
                new ButtonInfo { buttonText = "Menu Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the Menu settings for the menu."},
                new ButtonInfo { buttonText = "GunLib Settings", method =() => SettingsMods.GunLib(), isTogglable = false, toolTip = "Opens the GunLib settings for the menu."},
                new ButtonInfo { buttonText = "Notifications Settings", method =() => SettingsMods.Notification(), isTogglable = false, toolTip = "Opens the GunLib settings for the menu."},
                new ButtonInfo { buttonText = "Projectile Settings", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the GunLib settings for the menu."},
            },

            new ButtonInfo[] { // Advantages
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home for the menu."},
                new ButtonInfo { buttonText = "Tag Gun", method =() => Advantages.TagGun(), isTogglable = true },
                new ButtonInfo { buttonText = "Tag Self", method =() => Advantages.TagSelf(), isTogglable = true },
                new ButtonInfo { buttonText = "Tag All", method =() => Advantages.TagAll(), isTogglable = true },
                //new ButtonInfo { buttonText = "UnTag All <color=yellow>[M]</color>", method =() => Advantages.UnTagAll(), isTogglable = true },
                //new ButtonInfo { buttonText = "Tag Aura", method =() => Advantages.TagAura(), isTogglable = true },
            },

            new ButtonInfo[] { // Movement
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home for the menu."},
                new ButtonInfo { buttonText = "Platforms", method =() => Movement.Platforms(), isTogglable = true},
                new ButtonInfo { buttonText = "Invis Platforms", method =() => Movement.InvisPlatforms(), isTogglable = true},
                new ButtonInfo { buttonText = "Platform Spam", method =() => Movement.PlatformSpam(), isTogglable = true},
                new ButtonInfo { buttonText = "Platform Gun", method =() => Movement.PlatGun(), isTogglable = true},

                new ButtonInfo { buttonText = "Noclip", method =() => Movement.Noclip(), isTogglable = true},
                //new ButtonInfo { buttonText = "Grip Noclip", method =() => Movement.GripNoclip(), isTogglable = true},

                new ButtonInfo { buttonText = "Fly", method =() => Movement.Fly(), isTogglable = true},
                new ButtonInfo { buttonText = "Car Monke", method =() => Movement.CarMonke(), isTogglable = true},

                //new ButtonInfo { buttonText = "Low Gravity", method =() => Movement.LowGravity(), isTogglable = true},
                new ButtonInfo { buttonText = "High Gravity", method =() => Movement.HighGravity(), disableMethod =() => Movement.FixGrav(), isTogglable = true},
                new ButtonInfo { buttonText = "No Gravity", method =() => Movement.NoGravity(), disableMethod =() => Movement.FixGrav(), isTogglable = true},

                new ButtonInfo { buttonText = "Wall Walk", method =() => Movement.WallWalk(), isTogglable = true},
                new ButtonInfo { buttonText = "Up And Down", method =() => Movement.UpAndDown(), isTogglable = true},

                new ButtonInfo { buttonText = "Iron Monke", method =() => Movement.IronMonke(), isTogglable = true},
                new ButtonInfo { buttonText = "TP Gun", method =() => Movement.TPGun(), isTogglable = true},

                new ButtonInfo { buttonText = "Speed Boost", method =() => Movement.SpeedBoost(), isTogglable = true},
                new ButtonInfo { buttonText = "Mosa Boost", method =() => Movement.mosaboost(), isTogglable = true},
                new ButtonInfo { buttonText = "Super Speed", method =() => Movement.superspeed(), isTogglable = true},

                new ButtonInfo { buttonText = "Slide Control", method =() => Movement.SlideControl(), disableMethod =() => Movement.SlideControlfix(), isTogglable = true},

                new ButtonInfo { buttonText = "Rig Gun", method =() => Fun.RigGun(), isTogglable = true },
                new ButtonInfo { buttonText = "Long Arms", method =() => Fun.LongArms(), isTogglable = true, disableMethod =() => Fun.FixLongArms() },

                new ButtonInfo { buttonText = "Ghost Monke", method =() => Fun.Ghostmonke(), isTogglable = true },
                new ButtonInfo { buttonText = "Invis Monke", method =() => Fun.InvisMonke(), isTogglable = true },

                new ButtonInfo { buttonText = "Bunny Hop", method =() => Fun.BunnyHop(), isTogglable = true },
                //new ButtonInfo { buttonText = "Strafe", method =() => Fun.Strafe(), isTogglable = true },
                //new ButtonInfo { buttonText = "Dash <color=green>[A]</color>", method =() => Fun.Dash(), isTogglable = true },
            },

            new ButtonInfo[] { // visuals
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home for the menu."},
                new ButtonInfo { buttonText = "Tracers", method =() => Visuals.Tracers(), isTogglable = true},
                new ButtonInfo { buttonText = "Beacons", method =() => Visuals.Beacons(), isTogglable = true},
                new ButtonInfo { buttonText = "Box ESP", method =() => Visuals.BoxESP(), isTogglable = true},

                new ButtonInfo { buttonText = "Chams", method =() => Visuals.Chams(), disableMethod =() => Visuals.dischams(), isTogglable = true},

                new ButtonInfo { buttonText = "RGB Snowballs", method =() => Visuals.RGBSnowballs(), disableMethod =() => Visuals.FixRGBSnowballs(), isTogglable = true},
            },

            new ButtonInfo[] { // overpowered
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home for the menu."},
                /*new ButtonInfo { buttonText = "Grab Critters <color=green>[C]</color> <color=yellow>[M]</color>", method =() => Overpowered.GrabCritters(GorillaTagger.Instance.rightHandTransform), isTogglable = true },
                new ButtonInfo { buttonText = "Spam Critters <color=green>[C]</color> <color=yellow>[M]</color>", method =() => Overpowered.SpamCritters(), isTogglable = true },

                new ButtonInfo { buttonText = "Kick Gun <color=yellow>[PARTY]</color>", method = () => Overpowered.KickGun(), isTogglable = true },
                new ButtonInfo { buttonText = "Kick All <color=yellow>[PARTY]</color>", method = () => Overpowered.KickAll(), isTogglable = true },

                new ButtonInfo { buttonText = "Guardian Self <color=yellow>[M]</color>", method =() => Overpowered.GuardianSelf(), isTogglable = true },
                new ButtonInfo { buttonText = "Guardian Gun <color=yellow>[M]</color>", method =() => Overpowered.GuardianGun(), isTogglable = true },
                new ButtonInfo { buttonText = "Guardian Random <color=yellow>[M]</color>", method =() => Overpowered.GuardianRandom(), isTogglable = true },
                new ButtonInfo { buttonText = "Un Guardian <color=yellow>[M]</color>", method =() => Overpowered.UnGuardian(), isTogglable = true },
                new ButtonInfo { buttonText = "Grab All <color=green>[G]</color>", method =() => Overpowered.GrabAll(), isTogglable = true },
                new ButtonInfo { buttonText = "Grab Gun <color=green>[G]</color>", method =() => Overpowered.GrabGun(), isTogglable = true },
                new ButtonInfo { buttonText = "Release All <color=green>[G]</color>", method =() => Overpowered.ReleaseAll(), isTogglable = true },
                new ButtonInfo { buttonText = "Relese Gun <color=green>[G]</color>", method =() => Overpowered.ReleseGun(), isTogglable = true },*/
            },

            new ButtonInfo[] { // safety
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home for the menu."},
                new ButtonInfo { buttonText = "RPC Protection", method =() => Safety.RPCProtection(), isTogglable = true},
                new ButtonInfo { buttonText = "Flush RPCs", method =() => Safety.FlushRPCs(), isTogglable = true},
            },

            new ButtonInfo[] { // fun
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home for the menu."},
                //new ButtonInfo { buttonText = "Water Gun", method =() => Fun.WaterGun(), isTogglable = true },
                //new ButtonInfo { buttonText = "Water <color=green>[RG]</color>", method =() => Fun.WaterR(), isTogglable = true },
                //new ButtonInfo { buttonText = "Water <color=green>[LG]</color>", method =() => Fun.WaterL(), isTogglable = true },
                new ButtonInfo { buttonText = "Bubbles Spam <color=green>[RG]</color>", method =() => Fun.BubblesSpam(), isTogglable = true },

                new ButtonInfo { buttonText = "Caseoh Monke", method =() => Fun.CaseohMonke(), isTogglable = true },
                //new ButtonInfo { buttonText = "Disable Water", method =() => Fun.DisableWater(), isTogglable = true, disableMethod =() => Fun.FixWater() },
                //new ButtonInfo { buttonText = "Solid Water", method =() => Fun.SolidWater(), isTogglable = true, disableMethod =() => Fun.FixWater() },

                //new ButtonInfo { buttonText = "Rain", method =() => Fun.Rain(), isTogglable = true, disableMethod =() => Fun.FixRain() },

                //new ButtonInfo { buttonText = "Fast Swim", method =() => Fun.FastSwim(), isTogglable = true },
                //new ButtonInfo { buttonText = "Fast Turn Speed", method =() => Fun.fasturnspeed(), isTogglable = true, disableMethod =() => Fun.fixturnspeed() },

                //new ButtonInfo { buttonText = "Drone Monke", method =() => Fun.DroneMonke(), isTogglable = true, disableMethod =() => Fun.FixRig() },
                //new ButtonInfo { buttonText = "Heli Monke", method =() => Fun.HeliMonke(), isTogglable = true, disableMethod =() => Fun.FixRig() },
                //new ButtonInfo { buttonText = "Bayblade Monke", method =() => Fun.BaybladeMonke(), isTogglable = true, disableMethod =() => Fun.FixRig() },

                new ButtonInfo { buttonText = "Tp To Stump", method =() => Fun.TpToStump(), isTogglable = true },

                new ButtonInfo { buttonText = "Report All", method =() => Fun.ReportAll(), isTogglable = true },
                new ButtonInfo { buttonText = "Mute All", method =() => Fun.MuteAll(), isTogglable = true },
                new ButtonInfo { buttonText = "UnMute All", method =() => Fun.UnMuteAll(), isTogglable = true },
                new ButtonInfo { buttonText = "Report Gun", method =() => Fun.ReportGun(), isTogglable = true },

                //new ButtonInfo { buttonText = "Click Button Gun", method =() => Fun.ClickButtonGun(), isTogglable = true },

                new ButtonInfo { buttonText = "Mute Gun", method =() => Fun.MuteGun(), isTogglable = true },
                new ButtonInfo { buttonText = "Un Mute Gun", method =() => Fun.UnMuteGun(), isTogglable = true },

                new ButtonInfo { buttonText = "Mute All Music", method =() => Fun.MuteAllMusic(), isTogglable = true },
            },

            new ButtonInfo[] { // experimental
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home for the menu."},
                //new ButtonInfo { buttonText = "Lag All <color=green>[C]</color> <color=green>[RG]</color> <color=red>[CRASHES YOU TOO]</color>", method = () => Overpowered.SpawnCritterSpamLag(GorillaTagger.Instance.rightHandTransform), isTogglable = true },
                //new ButtonInfo { buttonText = "Crash All <color=green>[C]</color> <color=green>[RG]</color> <color=yellow>[BETA]</color> <color=red>[CRASHES YOU]</color>", method = () => Overpowered.SpawnCritterSpamCrash(GorillaTagger.Instance.rightHandTransform), isTogglable = true },
            },



            new ButtonInfo[] { // GunLib
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home for the menu."},
                /*new ButtonInfo { buttonText = "Equip Gun", method =() => mods.GunTemplate(), isTogglable = true, toolTip = "Equips a gun."},
                new ButtonInfo { buttonText = $"Smoothness: {(mods.num == 5f ? "Very Fast" : mods.num == 10f ? "Normal" : "Super Smooth")}", method = () => { mods.GunSmoothNess(); foreach (var category in Buttons.buttons) foreach (var button in category) if (button.buttonText.StartsWith("Smoothness")) button.buttonText = $"Smoothness: {(mods.num == 5f ? "Super Smooth" : mods.num == 10f ? "Normal" : "No Smooth")}"; }, isTogglable = false, toolTip = "Changes gun smoothness." },
                new ButtonInfo { buttonText = $"Gun Color: {mods.currentGunColor.name}", method = () => { mods.CycleGunColor(); Buttons.buttons.ForEach(category => category.ForEach(button => { if (button.buttonText.StartsWith("Gun Color")) button.buttonText = $"Gun Color: {mods.currentGunColor.name}"; })); }, isTogglable = false, toolTip = "Cycles through gun colors." },
                new ButtonInfo { buttonText = $"Toggle Sphere Size: {(mods.isSphereEnabled ? "Enabled" : "Disabled")}", method = () => { mods.isSphereEnabled = !mods.isSphereEnabled; if (mods.GunSphere != null) mods.GunSphere.transform.localScale = mods.isSphereEnabled ? new Vector3(0.1f, 0.1f, 0.1f) : new Vector3(0f, 0f, 0f); foreach (var category in Buttons.buttons) foreach (var button in category) if (button.buttonText.StartsWith("Toggle Sphere Size")) button.buttonText = $"Toggle Sphere Size: {(mods.isSphereEnabled ? "Enabled" : "Disabled")}"; }, isTogglable = false, toolTip = "Toggles the size of the gun sphere." }*/
            },

            new ButtonInfo[] { // MenuSettings
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home for the menu."},
                new ButtonInfo { buttonText = "Save", method =() => Settingss.Save(), isTogglable = true},
                new ButtonInfo { buttonText = "Load", method =() => Settingss.Load(), isTogglable = true},
                new ButtonInfo { buttonText = "Right/Left Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand()},
                new ButtonInfo { buttonText = "Change Theme", enableMethod =() => Settingss.ChangeMenuTheme(), disableMethod =() => SettingsMods.LeftHand()},
                new ButtonInfo { buttonText = "Animated Text", enableMethod =() => SettingsMods.EnableAnimText(), disableMethod =() => SettingsMods.DisableAnimText(), enabled = fpsCounter, toolTip = "Toggles the Animated Text."},
                //new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
                new ButtonInfo { buttonText = $"Delete Time: {(Main.num == 2f ? "Default" : Main.num == 5f ? "Long" : "Fast")}", method = () => { Main.MenuDeleteTime(); foreach (var category in Buttons.buttons) foreach (var button in category) if (button.buttonText.StartsWith("Delete Time")) button.buttonText = $"Delete Time: {(Main.num == 2f ? "Default" : Main.num == 5f ? "Long" : "Fast")}"; }, isTogglable = false, toolTip = "Changes menu delete time." },
    },

            new ButtonInfo[] { // Notifications
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home for the menu."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
            },

            new ButtonInfo[] { // proj settings
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home for the menu."},
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = true, toolTip = "placeholder."},


            },

            new ButtonInfo[] { // projectiles
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home for the menu."},
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = true, toolTip = "placeholder."},

            },

            new ButtonInfo[] { // projectiles
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home for the menu."},
                new ButtonInfo { buttonText = "Explosion", method =() => Particles.CreateDomain(), isTogglable = true, toolTip = "makes a Explosion."},
                new ButtonInfo { buttonText = "Sukuna's domain", method =() => Particles.CreateDomain2(), isTogglable = true, toolTip = "Sukuna's domain."},
                new ButtonInfo { buttonText = "Fire Fists", method =() => Particles.CreateFireEffect(), isTogglable = true, toolTip = "gives you Fire Fists."},
                new ButtonInfo { buttonText = "Black Hole", method =() => Particles.CreateBlackHole(), isTogglable = true, toolTip = "makes a Black Hole."},
                new ButtonInfo { buttonText = "White Hole", method =() => Particles.CreateWhiteHole(), isTogglable = true, toolTip = "makes a White Hole."},
                new ButtonInfo { buttonText = "Lighting", method =() => Particles.CreateLightningEffect(), isTogglable = true, toolTip = "Lighting."},
                new ButtonInfo { buttonText = "Magic Spell", method =() => Particles.CastMagicSpell(), isTogglable = true, toolTip = "cast a Magic Spell."},
                new ButtonInfo { buttonText = "Spark Magic Spell", method =() => Particles.CastSparkMagic(), isTogglable = true, toolTip = "cast a Spark Magic Spell."},
                new ButtonInfo { buttonText = "Light Magic Spell", method =() => Particles.CastLightMagic(), isTogglable = true, toolTip = "cast a Light Magic Spell."},
                new ButtonInfo { buttonText = "FireBall Magic Spell", method =() => Particles.CastFireballMagic(), isTogglable = true, toolTip = "cast a FireBall."},
                new ButtonInfo { buttonText = "Sword Slash", method =() => Particles.SwordSlash(), isTogglable = true, toolTip = "make a Sword Slash."},
                new ButtonInfo { buttonText = "Lighting Bolt Magic", method =() => Particles.CastLightningBolt(), isTogglable = true, toolTip = "Lighting Bolt Magic."},
                new ButtonInfo { buttonText = "Rift Magic", method =() => Particles.CastVoidRift(), isTogglable = true, toolTip = "Rift Magic."},
                new ButtonInfo { buttonText = "Frost Orb Magic", method =() => Particles.CastFrostOrb(), isTogglable = true, toolTip = "Frost Orb Magic."},
                new ButtonInfo { buttonText = "Nebula Storm", method =() => Particles.CreateNebulaStorm(), isTogglable = true, toolTip = "Nebula Storm."},
                new ButtonInfo { buttonText = "Draw", method =() => Particles.Draw(), isTogglable = true, toolTip = "Draw."},
            },



            //always keep this at the bottom if you add another tab (by going to categories) make sure you put that section above this one:

             new ButtonInfo[] {
                 new ButtonInfo { buttonText = "Disconnect", method =() => mods.Disconnect(), isTogglable = false, toolTip = "Disconnected from lobby"},
             },
            new ButtonInfo[] {
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home for the menu."},
            },
            new ButtonInfo[] {
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.MainSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
            },

        };
    }
}

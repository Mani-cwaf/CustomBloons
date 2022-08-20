using Assets.Scripts.Simulation.Towers;
using CustomBloons;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.ModOptions;
using HarmonyLib;
using MelonLoader;

[assembly: MelonInfo(typeof(CustomBloons.Main), ModHelperData.Name, ModHelperData.Version, "Mani_Dev")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace CustomBloons
{
    public class Main : BloonsTD6Mod
    {
        public static readonly ModSettingBool ShaggyTowerEnabled = true;
        public static readonly ModSettingBool OPFreeDartMonkeyEnabled = true;
        public static readonly ModSettingBool OPFreeGlueGunnerEnabled = true;
    }
}
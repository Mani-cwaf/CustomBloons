using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Models.Bloons.Behaviors;
using Assets.Scripts.Models.Bloons.Behaviors.Actions;
using Assets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Harmony;
using UnhollowerBaseLib;

namespace CustomBloons
{
    class CamoRegrowFortifiedRedBloon : ModBloon
    {
        public override string BaseBloon => BloonType.Red;
        public override string Icon => "CamGrowFortRed";
        public override bool UseIconAsDisplay => true;
        public override void ModifyBaseBloonModel(BloonModel bloon)
        {
            bloon.maxHealth = float.MaxValue;
            bloon.leakDamage = float.MaxValue;
            bloon.speed *= 5;
        }
    }
    class CamoRegrowFortifiedRedBloonDisplay : ModBloonDisplay<CamoRegrowFortifiedRedBloon>
    {
        public override string BaseDisplay => GetBloonDisplay("Red");
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, "CamGrowFortRed");
        }
    }
    class OrangeBloon : ModBloon
    {
        public override string BaseBloon => BloonType.Rainbow;
        public override string Icon => "Orange";
        public override bool UseIconAsDisplay => true;
        public override void ModifyBaseBloonModel(BloonModel bloon)
        {
            bloon.maxHealth = 10;
            bloon.AddBehavior(new ReflectProjectilesInRadiusActionModel("OrangeBloonReflectProjectilesInRadiusActionModel", "OrangeBloonShield", 99999999, 15, 15, 0.6f));
            bloon.AddBehavior(new TimeTriggerModel("OrangeBloonHealthTimeTriggerModel", 99999999, true, new string[] { "OrangeBloonShield" }));
        }
    }
    class OrangeBloonDisplay : ModBloonDisplay<OrangeBloon>
    {
        public override string BaseDisplay => GetBloonDisplay("Red");
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, "Orange");
        }
    }
}
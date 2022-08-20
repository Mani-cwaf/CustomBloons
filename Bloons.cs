using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Enums;

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
        public override string BaseBloon => BloonType.Black;
        public override string Icon => "CamGrowFortRed";
        public override bool UseIconAsDisplay => true;
        public override void ModifyBaseBloonModel(BloonModel bloon)
        {
        }
    }
    class OrangeBloonDisplay : ModBloonDisplay<OrangeBloon>
    {
        public override string BaseDisplay => GetBloonDisplay("Red");
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, "CamGrowFortRed");
        }
    }
}
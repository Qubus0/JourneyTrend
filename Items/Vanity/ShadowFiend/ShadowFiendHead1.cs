using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.ShadowFiend
{
    [AutoloadEquip(EquipType.Head)]
    public class ShadowFiendHead1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crimson Scourge Helmet");
            Tooltip.SetDefault("Ichor flows through you!\nMade by CakeBoiii");
        }
        
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.LightRed;
            item.vanity = true;
        }

        public override void AddRecipes()
        {
            ModRecipe alt = new ModRecipe(mod);
            alt.AddTile(mod.GetTile("SewingMachine"));
            alt.AddRecipeGroup("JourneyTrend:WorldEvilDemonHeads");
            alt.SetResult(this);
            alt.AddRecipe();
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<ShadowFiendBody1>() && legs.type == ItemType<ShadowFiendLegs1>();
        }

        public override void UpdateVanitySet(Player player)
        {
            if (Main.rand.NextFloat() < 0.1f)
            {
                Dust.NewDust(player.TopLeft, player.width, player.height, DustType<ShadowFiendDust1>());
            }
        }
    }
}


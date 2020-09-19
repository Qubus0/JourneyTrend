using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.ShadowFiend
{
    [AutoloadEquip(EquipType.Head)]
    public class ShadowFiendHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Fiend Helmet");
            Tooltip.SetDefault("Cursed Flames consume you!\nMade by CakeBoiii");
        }
        
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.LightPurple;
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
            return body.type == ItemType<ShadowFiendBody>() && legs.type == ItemType<ShadowFiendLegs>();
        }

        public override void UpdateVanitySet(Player player)
        {
            if (player.velocity != Vector2.Zero && Main.rand.NextFloat() < 0.2f)
            {
                Dust.NewDust(player.Center - new Vector2(player.direction * 10 + 5, 20), 10, 40, DustType<ShadowFiendDust>());
            }
        }
    }
}


using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;


namespace JourneyTrend.Tiles
{
    public class SewingMachine : ModTile
    {
        private const int AnimationFramePixelHeight = 20;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table | AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.CoordinateHeights = new[] {18}; // 18 to extend into grass tiles.
            TileObjectData.newTile.Direction = TileObjectDirection.PlaceLeft;
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceRight; // allows placing tiles facing the same way as the player
            TileObjectData.addAlternate(1); // facing right will use the second texture
            TileObjectData.addTile(Type);
            
            var name = CreateMapEntryName();
            // name.SetDefault(Language.GetTextValue("Mods.JourneyTrend.MapObject.SewingMachine"));
            AddMapEntry(new Color(175, 175, 215), name);
        }

        public override void AnimateIndividualTile(int type, int i, int j, ref int frameXOffset, ref int frameYOffset)
        {
            // Tweak the frame drawn by x position so tiles next to each other are off-sync and look much more interesting.
            var uniqueAnimationFrame = Main.tileFrame[Type] + i;
            if (i % 2 == 0) uniqueAnimationFrame += 3;
            if (i % 3 == 0) uniqueAnimationFrame += 3;
            if (i % 4 == 0) uniqueAnimationFrame += 3;
            uniqueAnimationFrame %= 4;

            frameYOffset = uniqueAnimationFrame * AnimationFramePixelHeight;
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            // Spend 9 ticks on each of 6 frames, looping
            // frameCounter++;
            // if (frameCounter > 8)
            // {
            // 	frameCounter = 0;
            // 	frame++;
            // 	if (frame > 3)
            // 	{
            // 		frame = 0;
            // 	}
            //  }
            // Or, more compactly:
            if (++frameCounter >= 5)
            {
                frameCounter = 0;
                frame = ++frame % 4;
            }
        }


        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 16, ModContent.ItemType<Items.Placeable.SewingMachine>());
        }
    }
}
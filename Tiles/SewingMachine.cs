using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Enums;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using static Terraria.ModLoader.ModContent;

  


namespace JourneyTrend.Tiles
{
	public class SewingMachine : ModTile
	{
		public override void SetDefaults() {
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table | AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
			TileObjectData.newTile.CoordinateHeights = new int[] { 18 }; // 18 to extend into grass tiles.
			TileObjectData.newTile.Direction = TileObjectDirection.PlaceLeft;
			TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
			TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceRight; //allows me to place example chairs facing the same way as the player
			TileObjectData.addAlternate(1); //facing right will use the second texture
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Sewing Machine");
			AddMapEntry(new Color(200, 200, 200), name);
			disableSmartCursor = true;
			adjTiles = new int[] { TileID.WorkBenches };
			AddMapEntry(new Color(200, 200, 200), name);
		}

		private readonly int animationFrameHeight = 20;

		public override void AnimateIndividualTile(int type, int i, int j, ref int frameXOffset, ref int frameYOffset) {
			// Tweak the frame drawn by x position so tiles next to each other are off-sync and look much more interesting.
			int uniqueAnimationFrame = Main.tileFrame[Type] + i;
			if (i % 2 == 0) {
				uniqueAnimationFrame += 3;
			}
			if (i % 3 == 0) {
				uniqueAnimationFrame += 3;
			}
			if (i % 4 == 0) {
				uniqueAnimationFrame += 3;
			}
			uniqueAnimationFrame = uniqueAnimationFrame % 4;

			frameYOffset = uniqueAnimationFrame * animationFrameHeight;
		}

		public override void AnimateTile(ref int frame, ref int frameCounter) {
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
			if (++frameCounter >= 0)
			{
				frameCounter = 0;
				frame = ++frame % 4;
			}
		}


		public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			Item.NewItem(i * 16, j * 16, 32, 16, ItemType<Items.Placeable.SewingMachine>());
		}
	}
}
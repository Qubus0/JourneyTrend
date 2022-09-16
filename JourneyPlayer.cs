using System.Collections.Generic;
using JourneyTrend.Items.Vanity.Traveller;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace JourneyTrend
{
    public class JourneyPlayer : ModPlayer
    {
        // Starting Items
        public override IEnumerable<Item> AddStartingItems(bool mediumcoreDeath)
        {
            return new[] {
                new Item(ModContent.ItemType<TravellerHead>()),
                new Item(ModContent.ItemType<TravellerBody>()),
                new Item(ModContent.ItemType<TravellerLegs>())
            };

        }

        public int walkUpShift; //-2 when the walk cycle has 'up' frames
        private bool isIdle; //true if not moving
        private bool isJumping; //true if the 6th player frame (jump) is used
        public bool doOffset; //used for the rookie hand offset (because it is lower than normal)

        public bool BubbleheadHeadEquipped;
        private int BubbleheadHeadFrameCounter;
        private int BubbleheadHeadFrameUpdater;
        private int BubbleheadHeadTickToFrame;

        public bool PlanetaryHeadEquipped;
        private int PlanetaryHeadRingTickToFrame;
        private int PlanetaryHeadRingFrameUpdater;
        private int PlanetaryHeadRingFrameCounter = 0;
        private int PlanetaryHeadWaterTickToFrame;
        private int PlanetaryHeadWaterFrameUpdater;
        private int PlanetaryHeadWaterFrameCounter = 0;

        public bool KnightwalkerBodyEquipped; //corresponding equip bool
        private int KnightwalkerCapeFrameCounter;
        private int KnightwalkerCapeFrameUpdater;
        private int KnightwalkerCapeTickToFrame;
        private int KnightwalkerFlameFrameCounter;
        private int KnightwalkerFlameFrameUpdater;
        private int KnightwalkerFlameTickToFrame;

        public bool KnightwalkerAlt;

        public bool KnightwalkerHeadEquipped;
        private int KnightwalkerHeadFrameCounter;
        private int KnightwalkerHeadFrameUpdater;
        private int KnightwalkerHeadTickToFrame;

        public bool NineTailedFoxAccEquipped;
        private int NineTailedFoxFrameCounter;
        public int NineTailedFoxFrameIndex;
        private int NineTailedFoxTickCounter;
        
        public bool StarlightBodyEquipped; // Corresponding equip bool

        public override void PreUpdate()
        {
            if (Player.velocity == Vector2.Zero)
                isIdle = true;
            else
                isIdle = false;

            //0,frameNum * frame hei, width, height
            var pl = Player.bodyFrame.Y / 56;
            if (pl == 5)
                isJumping = true;
            if (pl == 7 || pl == 8 || pl == 9 || pl == 14 || pl == 15 || pl == 16)
                walkUpShift = -2;
            else
                walkUpShift = 0;


            if (NineTailedFoxAccEquipped)
            {
                NineTailedFoxTickCounter++;
                if (NineTailedFoxTickCounter == 8) //every 8 ticks update
                {
                    NineTailedFoxTickCounter = 0;
                    NineTailedFoxFrameCounter++; //next frame
                    if (NineTailedFoxFrameCounter >= 10) //loop all frames from 0 to 9
                        NineTailedFoxFrameCounter = 0; //reset to first frame
                }

                NineTailedFoxFrameIndex = isJumping ? 10 : NineTailedFoxFrameCounter;
            }
        }

        public override void ResetEffects() //reset all the equip type booleans
        {
            isIdle = false;
            isJumping = false;
            NineTailedFoxAccEquipped = false;
            StarlightBodyEquipped = false;
            KnightwalkerBodyEquipped = false;
            KnightwalkerHeadEquipped = false;
            BubbleheadHeadEquipped = false;
            PlanetaryHeadEquipped = false;
        }
    }
}

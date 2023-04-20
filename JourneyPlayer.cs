using JourneyTrend.Items.Vanity.Bubblehead;
using JourneyTrend.Items.Vanity.Knightwalker;
using JourneyTrend.Items.Vanity.NineTailedFox;
using JourneyTrend.Items.Vanity.Planetary;
using Terraria;
using Terraria.ModLoader;

namespace JourneyTrend
{
    public class JourneyPlayer : ModPlayer
    {
        public bool DoOffset; // used for the rookie hand offset (because it is lower than normal)

        public bool StarlightDreamBodyEquipped;
        // no frame counter needed, it's in sync with the player's body frame

        public bool BubbleheadHeadEquipped;
        public readonly AnimationFrameCounter BubbleheadHeadAnimationFrameCounter = 
            new(BubbleheadHeadAnimatedDrawLayerAlwaysBubbles.FrameCount, 6);

        
        public bool PlanetaryHeadEquipped;
        public readonly AnimationFrameCounter PlanetaryHeadAlwaysRingFrameCounter =
            new(PlanetaryHeadAnimatedDrawLayerAlwaysRingFront.FrameCount, 6);
        
        public readonly AnimationFrameCounter PlanetaryHeadAlwaysStarsFrameCounter = 
            new(PlanetaryHeadAnimatedDrawLayerAlwaysStars.FrameCount, 30);

        public readonly AnimationFrameCounter PlanetaryHeadIdleWaterFrameCounter =
            new(PlanetaryHeadAnimatedDrawLayerIdleWater.FrameCount, 8);

        
        public bool KnightwalkerBodyEquipped;
        public readonly AnimationFrameCounter KnightwalkerBodyIdleCapeAnimationFrameCounter = 
            new(KnightwalkerBodyAnimatedDrawLayerIdleCape.FrameCount, 8);
        
        public readonly AnimationFrameCounter KnightwalkerBodyIdleFlameAnimationFrameCounter = 
            new(KnightwalkerBodyAnimatedDrawLayerIdleFlameFront.FrameCount, 6);

        public bool KnightwalkerHeadEquipped;
        public readonly AnimationFrameCounter KnightwalkerHeadAlwaysFlameAnimationFrameCounter = 
            new(KnightwalkerHeadAnimatedDrawLayerAlwaysFlame.FrameCount, 6);


        public bool NineTailedFoxAccBackEquipped;
        public readonly AnimationFrameCounter NineTailedFoxAccBackAnimationFrameCounter = 
            new(NineTailedFoxAccBackAnimatedDrawLayerAlwaysTails.FrameCount -1, 8);

        
        public int GetPlayerBodyFrameYIndex()
        {
            return Player.bodyFrame.Y / 56;
        }

        public int GetWalkUpShift()
        {
            if (GetPlayerBodyFrameYIndex() is 7 or 8 or 9 or 14 or 15 or 16)
                return -2;
            return 0;
        }

        public bool IsJumping()
        {
            // true if the 6th player frame (jump) is used
            return GetPlayerBodyFrameYIndex() == 5;
        }

        public bool IsIdle()
        {
            // true if not moving
            return Player.velocity.Length() < 0.1f;
        }

        public override void ResetEffects() // reset all the equip type booleans
        {
            NineTailedFoxAccBackEquipped = false;
            StarlightDreamBodyEquipped = false;
            KnightwalkerBodyEquipped = false;
            KnightwalkerHeadEquipped = false;
            BubbleheadHeadEquipped = false;
            PlanetaryHeadEquipped = false;
        }
    }
    
    public class AnimationFrameCounter
    {
        private readonly int AnimationFrameCount;
        private int FrameIndex;
        private readonly int FrameTickDuration;
        private int TickIndex;

        public AnimationFrameCounter(int animationFrameCount, int frameTickDuration)
        {
            AnimationFrameCount = animationFrameCount;
            FrameTickDuration = frameTickDuration;
        }
        
        public int GetFrameIndex()
        {
            return FrameIndex;
        }

        public void NextFrame()
        {
            TickIndex++;
            if (TickIndex == FrameTickDuration)
                IncrementAndWrapFrame();
            WrapTick();
        }

        private void IncrementAndWrapFrame()
        {
            FrameIndex++;
            if (FrameIndex >= AnimationFrameCount)
                FrameIndex = 0;
        }
        
        private void WrapTick()
        {
            if (TickIndex >= FrameTickDuration)
                TickIndex = 0;
        }
    }
}

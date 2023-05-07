using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Shaders;

namespace JourneyTrend;

public static class ColorUtils
{
    /// <summary>
    /// Adds a light to the player that is responsive to dyes
    /// </summary>
    /// <param name="unshadedLightColor"></param>
    /// <param name="shaderSlot">The slot that the color should respond to. e.g. player.cHead</param>
    /// <param name="player"></param>
    public static Vector3 ShaderResponsiveColor(Color unshadedLightColor, int shaderSlot, Player player)
    {
        var dyeShader = GameShaders.Armor.GetSecondaryShader(shaderSlot, player);

        if (dyeShader == null) return unshadedLightColor.ToVector3();

        var shaderColor = new Color(dyeShader.Shader.Parameters["uColor"].GetValueVector3());
        return SetColorBrightness(shaderColor, GetColorBrightness(unshadedLightColor)).ToVector3();
    }

    /// <summary>
    /// calculates the brightness of a color
    /// </summary>
    /// <param name="color"></param>
    /// <returns></returns>
    public static int GetColorBrightness(Color color)
    {
        // https://stackoverflow.com/questions/596216/formula-to-determine-brightness-of-rgb-color
        return (int)Math.Sqrt(
            color.R * color.R * .241 +
            color.G * color.G * .691 +
            color.B * color.B * .068);
    }

    /// <summary>
    /// returns a color with the same hue and saturation as the input color, but with the brightness set to the input value
    /// </summary>
    /// <param name="color"></param>
    /// <param name="brightness"></param>
    /// <returns></returns>
    private static Color SetColorBrightness(Color color, int brightness)
    {
        var colorBrightness = GetColorBrightness(color);
        var brightnessRatio = (float)brightness / colorBrightness;
        return new Color(
            (int)(color.R * brightnessRatio),
            (int)(color.G * brightnessRatio),
            (int)(color.B * brightnessRatio));
    }
    
    /// <summary>
    /// returns a color dimmed to the specified brightness, in percent from 0 to 1
    /// </summary>
    /// <param name="color"></param>
    /// <param name="brightness"></param>
    /// <returns></returns>
    public static Color DimColor(Color color, float brightness)
    {
        return new Color(
            (int)(color.R * brightness),
            (int)(color.G * brightness),
            (int)(color.B * brightness));
    }
}
using Humanizer;
using Microsoft.Xna.Framework;

namespace BetterDamageNumbers.TextModifiers;

internal sealed class RomanNumeralModifier : DamageNumberModifier
{
    public override string Name => "Roman Numerals";

    public override string Process(int damageValue, Rectangle location, Color color, bool dramatic, bool dot) => RomanNumeralExtensions.ToRoman(damageValue);
}

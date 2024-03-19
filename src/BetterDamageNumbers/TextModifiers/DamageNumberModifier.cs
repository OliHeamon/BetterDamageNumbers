using Microsoft.Xna.Framework;

namespace BetterDamageNumbers.TextModifiers;

internal abstract class DamageNumberModifier
{
    public readonly string ModifierName;

    public DamageNumberModifier()
    {
        ModifierName = Name;
    }

    public abstract string Name { get; }

    public abstract string Process(int damageValue, Rectangle location, Color color, bool dramatic, bool dot);
}

using BetterDamageNumbers.Configs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace BetterDamageNumbers;

internal sealed class CombatTextModifierSystem : ModSystem
{
    public override void Load()
    {
        On_CombatText.NewText_Rectangle_Color_int_bool_bool += NewTextInt;
        On_CombatText.NewText_Rectangle_Color_string_bool_bool += NewTextString;
    }

    private int NewTextString(On_CombatText.orig_NewText_Rectangle_Color_string_bool_bool orig, Rectangle location, Color color, string text, bool dramatic, bool dot)
    {
        BetterDamageNumbersConfig config = ModContent.GetInstance<BetterDamageNumbersConfig>();

        // Damage number, rather than some other combat text containing a number.
        if (int.TryParse(text, out int damageNumber))
        {
            return orig(location, color, config.ActiveModifier.Process(damageNumber, location, color, dramatic, dot), dramatic, dot);
        }

        return orig(location, color, text, dramatic, dot);
    }

    // In the int version, a string cannot be returned, meaning the combat text cannot be changed to non-numeric values.
    // This redirect ensures all NewText calls result in strings so that they can be manipulated appropriately.
    private int NewTextInt(On_CombatText.orig_NewText_Rectangle_Color_int_bool_bool orig, Rectangle location, Color color, int amount, bool dramatic, bool dot)
    {
        return CombatText.NewText(location, color, amount.ToString(), dramatic, dot);
    }
}

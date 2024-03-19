using BetterDamageNumbers.TextModifiers;
using Newtonsoft.Json;
using Terraria.ModLoader.Config;

namespace BetterDamageNumbers.Configs
{
    internal class BetterDamageNumbersConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [JsonIgnore]
        public DamageNumberModifier ActiveModifier { get; set; } = new RomanNumeralModifier();
    }
}

using Terraria.ModLoader;

namespace VerbotenMode
{
    public class VerbotenMode : Mod
	{
        internal static VerbotenMode Instance;

        internal static Mod Calamity;
        internal static Mod CalamityMusic;

        public override void Load()
        {
            Instance = this;

            Calamity = ModLoader.GetMod("CalamityMod");
            ModLoader.TryGetMod("CalamityModMusic", out CalamityMusic);
        }

        public override void Unload()
        {
            Instance = null;

            Calamity = null;
            CalamityMusic = null;
        }
    }
}
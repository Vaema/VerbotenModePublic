﻿using Terraria;
using VerbotenMode.Common.Players;

namespace VerbotenMode.Common.Utilities
{
    public static partial class VerbotenUtils
    {
        public static DifficultyChangesPlayer Verboten_Changes(this Player player) => player.GetModPlayer<DifficultyChangesPlayer>();
    }
}
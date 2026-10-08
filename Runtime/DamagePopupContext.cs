using UnityEngine;

namespace CupkekGames.TextPopup
{
    /// <summary>
    /// Per-call context for damage popups: whether the hit was a crit (adapters show a crit's
    /// own look) and the colour to tint it (a game's element colour, say); no colour leaves the
    /// popup untinted.
    /// </summary>
    public class DamagePopupContext : IPopupContext
    {
        /// <summary>A critical hit.</summary>
        public bool IsCrit;

        /// <summary>The popup's tint; null leaves it untinted.</summary>
        public Color? Color;
    }
}

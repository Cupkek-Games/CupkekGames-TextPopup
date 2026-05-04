namespace CupkekGames.TextPopup
{
    /// <summary>
    /// Reserved popup-kind string constants.
    /// Call sites should use these constants instead of hand-written magic strings,
    /// but the catalog stays open — domain games add new kinds without editing this class.
    /// </summary>
    public static class PopupKinds
    {
        public const string Damage = "Damage";
        public const string DamageWeak = "DamageWeak";
        public const string DamageStrong = "DamageStrong";
        public const string Heal = "Heal";
        public const string Shield = "Shield";
        public const string StatusPositive = "StatusPositive";
        public const string StatusNegative = "StatusNegative";

        /// <summary>
        /// Maps an element multiplier to the appropriate damage kind:
        /// &lt;1 → <see cref="DamageWeak"/>, &gt;1 → <see cref="DamageStrong"/>, otherwise <see cref="Damage"/>.
        /// </summary>
        public static string DamageVariant(float elementMultiplier)
        {
            if (elementMultiplier < 1f) return DamageWeak;
            if (elementMultiplier > 1f) return DamageStrong;
            return Damage;
        }
    }
}

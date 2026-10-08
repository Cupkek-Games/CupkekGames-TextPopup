namespace CupkekGames.TextPopup
{
    /// <summary>
    /// Per-call context for damage popups: whether the hit was a crit (adapters show a crit's
    /// own look).
    /// </summary>
    public class DamagePopupContext : IPopupContext
    {
        /// <summary>A critical hit.</summary>
        public bool IsCrit;
    }
}

namespace CupkekGames.TextPopup
{
    /// <summary>
    /// Per-call context for damage popups. Drives crit-prefix lookup in the adapter.
    /// </summary>
    public class DamagePopupContext : IPopupContext
    {
        /// <summary>
        /// When <c>true</c>, the adapter prepends the kind's configured crit prefix
        /// to the popup's left text (e.g. <c>"★-{value}"</c>).
        /// </summary>
        public bool IsCrit;
    }
}

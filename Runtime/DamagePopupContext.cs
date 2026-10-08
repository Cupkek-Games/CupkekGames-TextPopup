namespace CupkekGames.TextPopup
{
    /// <summary>
    /// Per-call context for damage popups: how the hit landed. Adapters pick the popup's look
    /// from it (a crit's, a killing blow's).
    /// </summary>
    public class DamagePopupContext : IPopupContext
    {
        /// <summary>A critical hit.</summary>
        public bool IsCrit;

        /// <summary>The hit felled its target.</summary>
        public bool IsKill;

        /// <summary>The hit felled its target with far more than it had left (only with <see cref="IsKill"/>).</summary>
        public bool IsOverkill;
    }
}

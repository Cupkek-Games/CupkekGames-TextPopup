namespace CupkekGames.TextPopup
{
    /// <summary>
    /// Per-call context for text-only popups (status effects like "DISABLED" / "STUN").
    /// Overrides the kind's default left text on a single call.
    /// </summary>
    public class TextPopupContext : IPopupContext
    {
        public string LeftText;
    }
}

namespace CupkekGames.TextPopup
{
    /// <summary>
    /// Marker interface for per-call popup context payloads.
    /// Concrete implementations carry kind-specific extras (crit flag, override text, etc.).
    /// Adapters use pattern matching to extract relevant data; unrecognised contexts are ignored.
    /// </summary>
    public interface IPopupContext { }
}

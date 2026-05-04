using UnityEngine;

namespace CupkekGames.TextPopup
{
    /// <summary>
    /// Single kind-driven entry point for spawning popups (damage, heal, shield, status effects, etc.).
    /// Kinds are designer-defined string keys; new kinds are added by registering a (kind, prefab) entry
    /// on the adapter, not by editing this interface.
    /// </summary>
    public interface IPopupManager
    {
        /// <summary>
        /// Spawn a popup of the given <paramref name="kind"/> at <paramref name="center"/> displaying <paramref name="value"/>.
        /// Pass an <see cref="IPopupContext"/> for per-kind extras (crit flag, override text, etc.).
        /// Unknown kinds are silently ignored.
        /// </summary>
        void Show(string kind, Vector3 center, int value = 0, IPopupContext context = null);

        /// <summary>
        /// Hint for scaling popup visuals — adapters that scale by value (e.g. damage numbers
        /// growing with magnitude) use this to bound the visual range. Adapters without
        /// value-driven scaling can ignore the call.
        /// </summary>
        void SetScaleMaxValue(float maxValue);
    }
}

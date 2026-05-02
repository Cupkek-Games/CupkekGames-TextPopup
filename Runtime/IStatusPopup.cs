using UnityEngine;

namespace CupkekGames.TextPopup
{
    public interface IStatusPopup
    {
        void ShowStatusEffect(Vector3 center, bool positive, string text);

        /// <summary>
        /// Show a numeric popup for a caller-defined effect kind. The implementation
        /// looks up <paramref name="kind"/> in its configured prefab map; unknown
        /// kinds are silently ignored.
        /// </summary>
        void ShowEffect(Vector3 center, string kind, int value);
    }
}

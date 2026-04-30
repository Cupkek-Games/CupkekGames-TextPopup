using UnityEngine;

namespace CupkekGames.TextPopup
{
    public interface IStatusPopup
    {
        void ShowStatusEffect(Vector3 center, bool positive, string text);
    }
}

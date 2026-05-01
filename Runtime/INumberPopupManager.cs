using UnityEngine;

namespace CupkekGames.TextPopup
{
    public interface INumberPopupManager
    {
        void ShowDamage(Vector3 center, int value, float elementMultiplier, bool isCrit);
        void ShowHeal(Vector3 center, int value);
    }
}

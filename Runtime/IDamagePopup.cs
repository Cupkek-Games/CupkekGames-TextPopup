using UnityEngine;

namespace CupkekGames.TextPopup
{
    public interface IDamagePopup
    {
        void ShowDamage(Vector3 center, int value, float elementMultiplier, bool isCrit);
        void SetScaleMaxDamage(float maxDamage);
    }
}

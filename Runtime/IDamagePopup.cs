using UnityEngine;

namespace CupkekGames.TextPopup
{
    public interface IDamagePopup
    {
        void ShowDamage(Vector3 center, int value, float elementMultiplier, bool isCrit);
        void ShowPoison(Vector3 center, int value);
        void ShowBleed(Vector3 center, int value);
        void SetScaleMaxDamage(float maxDamage);
    }
}

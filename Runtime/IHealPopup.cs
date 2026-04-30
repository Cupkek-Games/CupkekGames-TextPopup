using UnityEngine;

namespace CupkekGames.TextPopup
{
    public interface IHealPopup
    {
        void ShowHeal(Vector3 center, int value);
        void ShowShield(Vector3 center, int value);
    }
}

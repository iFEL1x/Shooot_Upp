using CodeBase.Handler;
using UnityEngine;

namespace CodeBase.Components.Events
{
    public class AddAmmoComponent : MonoBehaviour
    {
        [SerializeField] private int _addAmmoCount = 5;
        [SerializeField] private AmmoCounter _ammoCounter;

        public void AddAmmo() =>
            _ammoCounter.Ammo += _addAmmoCount;
    }
}

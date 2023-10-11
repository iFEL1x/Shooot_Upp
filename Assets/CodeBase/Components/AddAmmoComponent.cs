using UnityEngine;
using CodeBase.Handler;

namespace CodeBase.Components
{
    public class AddAmmoComponent : MonoBehaviour
    {
        [SerializeField] private int _addAmmoCount = 5;
        [SerializeField] private AmmoCounter _ammoCounter;

        public void AddAmmo() =>
            _ammoCounter.Ammo += _addAmmoCount;
    }
}

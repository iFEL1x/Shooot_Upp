using UnityEngine;
using CodeBase.Player;

namespace CodeBase.Components
{
    public class AddAmmoComponent : MonoBehaviour
    {
        [SerializeField] private int _addAmmoCount = 5;
        private const string _TAG_PLAYER = "Player";
        private AmmoContainer _ammoContainer;


        private void Awake() =>
            _ammoContainer = GameObject.FindGameObjectWithTag(_TAG_PLAYER).GetComponent<AmmoContainer>();
        
        public void AddAmmo() =>
            _ammoContainer.Ammo += _addAmmoCount;
    }
}

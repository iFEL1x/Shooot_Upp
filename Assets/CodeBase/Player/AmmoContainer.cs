using UnityEngine;
using TMPro;

namespace CodeBase.Player
{
    public class AmmoContainer : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textMesh;
        [SerializeField] private int _maxAmmo = 10;

        private void Start() =>
            _textMesh.text = _maxAmmo.ToString();

        public int Ammo
        {
            get { return _maxAmmo; }
            set
            {
                if (_maxAmmo >= 0)
                {
                    _maxAmmo = value;
                    _textMesh.text = _maxAmmo.ToString();
                }
            }
        }
    }
}

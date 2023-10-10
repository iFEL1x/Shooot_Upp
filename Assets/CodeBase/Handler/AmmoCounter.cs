using TMPro;
using UnityEngine;

namespace CodeBase.Handler
{
    public class AmmoCounter : MonoBehaviour
    {
        [SerializeField] private int _maxAmmo = 10;
        [SerializeField] private TMP_Text _textMesh;

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

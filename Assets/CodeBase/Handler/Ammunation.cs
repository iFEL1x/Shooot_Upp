using TMPro;
using UnityEngine;

namespace CodeBase.Handler
{
    public class Ammunation : MonoBehaviour
    {
        [SerializeField] private int _maxAmmo = 10;
        [SerializeField] private TMP_Text _textMesh;

        public int Ammmo
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

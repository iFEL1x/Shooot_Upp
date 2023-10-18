using UnityEngine;
using TMPro;

namespace CodeBase.Player
{
    public class CoinsContainer : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textMesh;
        private int _currentCoins;

        public int CurrentCoins
        {
            get { return _currentCoins; }
            set
            {
                _currentCoins = value;
                _textMesh.text = CurrentCoins.ToString();
            }
        }

        private void Start() =>
            _textMesh.text = CurrentCoins.ToString();
    }
}

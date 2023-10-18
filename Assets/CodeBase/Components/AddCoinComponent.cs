using UnityEngine;
using CodeBase.Player;

namespace CodeBase.Components
{
    public class AddCoinComponent : MonoBehaviour
    {
        private const string _TAG_PLAYER = "Player";
        private CoinsContainer _coinsContainer;

        private void Awake() =>
            _coinsContainer = GameObject.FindGameObjectWithTag(_TAG_PLAYER).GetComponent<CoinsContainer>();

        public void AddCoin() =>
            _coinsContainer.CurrentCoins++;
    }
}

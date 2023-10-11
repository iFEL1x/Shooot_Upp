using UnityEngine;
using CodeBase.Handler;

namespace CodeBase.Components
{
    public class AddCoinComponent : MonoBehaviour
    {
        [SerializeField] private CoinsCounter _coinsCounter;

        public void AddCoin() =>
            _coinsCounter.CurrentCoins++;
    }
}

using CodeBase.Player;
using UnityEngine;

namespace CodeBase.Utils
{
    public class CloneCreation : MonoBehaviour
    {
        [SerializeField] private GameObject _clone;
        
        private void Start()
        {
            GameObject clone = Instantiate(_clone);
            clone.GetComponent<GunClone>().Gun = gameObject;
        }
    }
}
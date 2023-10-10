using UnityEngine;

namespace CodeBase.Utils
{
    public class CloneCreation : MonoBehaviour
    {
        [SerializeField] private GameObject _clone;
        
        private void Start()
        {
            Instantiate(_clone);
        }
    }
}
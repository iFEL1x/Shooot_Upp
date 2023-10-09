using UnityEngine;
using CodeBase.Component;

namespace CodeBase
{
    public class CloneCreation : MonoBehaviour
    {
        [SerializeField] private GameObject _clone;
        private bool _isLeftSet;
        
        private void Start()
        {
            for (int i = 0; i < 2; i++)
            {
                GameObject obj = Instantiate(_clone);
                
                if (_isLeftSet) return;
                
                obj.GetComponent<ControlCloneComponent>()._isLeft = true;
                _isLeftSet = true;
            }
        }
    }
}

using System;
using UnityEngine;
using UnityEngine.Events;

namespace CodeBase.Components
{
    public class CollisionComponent : MonoBehaviour
    {
        [SerializeField] private string _name;
        [SerializeField] private EnterEvent _action;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.CompareTag(_name))
            {
                _action.Invoke(other.gameObject);
            }
        }
    }
            
    [Serializable]
    public class EnterEvent : UnityEvent<GameObject>
    {
    }
}

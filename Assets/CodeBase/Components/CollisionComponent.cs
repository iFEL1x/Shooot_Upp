using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CodeBase.Components
{
    public class CollisionComponent : MonoBehaviour
    {
        [SerializeField] private CollisionEvent[] _collisionEvents;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            foreach (CollisionEvent colEvent in _collisionEvents)
            {
                if(colEvent.Tag.Contains(other.tag))
                {
                    colEvent.Action.Invoke(other.gameObject);
                    break;
                }
            }
        }
    }

    [Serializable]
    public class CollisionEvent 
    {
        public List<string> Tag;
        public EnterEvent Action;
    }
    
    [Serializable]
    public class EnterEvent : UnityEvent<GameObject>
    {
    }
}

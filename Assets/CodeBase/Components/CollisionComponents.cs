using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CodeBase.Components
{
    public class CollisionComponents : MonoBehaviour
    {
        [SerializeField] private bool _returnCollision;
        [SerializeField] private CollisionEvent[] _collisionEvents;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            foreach (CollisionEvent collisionEvent in _collisionEvents)
            {
                if(collisionEvent.Tag.Contains(other.tag))
                {
                    GameObject obj = _returnCollision ? other.gameObject : gameObject;
                    collisionEvent.Action.Invoke(obj);
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

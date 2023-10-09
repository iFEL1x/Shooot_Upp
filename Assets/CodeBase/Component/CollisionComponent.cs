using UnityEngine;

namespace CodeBase.Component
{
    public class CollisionComponent : MonoBehaviour
    {
        [SerializeField] private string _name;
        private ObjectPool _pool;

        private void Start()
        {
            _pool = FindObjectOfType<ObjectPool>();
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.CompareTag(_name))
            {
                other.gameObject.SetActive(false);
                _pool.ReturnToPool(other.gameObject);
                Debug.Log(gameObject.name);
            }
        }
    }
}

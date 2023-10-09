using UnityEngine;

namespace CodeBase.Component
{
    public class CollisionComponent : MonoBehaviour
    {
        [SerializeField] private string _name;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.CompareTag(_name))
            {
                Destroy(gameObject);
            }
        }
    }
}

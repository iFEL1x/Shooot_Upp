using UnityEngine;
using CodeBase.Pool;

namespace CodeBase.Components.Events
{
    public class ReturnToPoolComponent : MonoBehaviour
    {
        [SerializeField] private ObjectPool _pool;
        
        public void ReturnToPool(GameObject obj)
        {
            obj.SetActive(false);
            _pool.ReturnToPool(obj);
        }
    }
}

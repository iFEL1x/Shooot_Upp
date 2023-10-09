using System.Collections.Generic;
using UnityEngine;

namespace CodeBase
{
    public class ObjectPool : MonoBehaviour
    {
        protected static List<GameObject> Pool;

        [SerializeField] private GameObject _prefab;
        [SerializeField] private int _sizePool;

        protected virtual void Start()
        {
            CreatePool();
        }

        private void CreatePool()
        {
            Pool = new List<GameObject>();

            for (int i = 0; i < _sizePool; i++)
            {
                GameObject obj = Instantiate(_prefab, transform.position, Quaternion.identity);
                obj.SetActive(false);
                Pool.Add(obj);
            }
        }

        public void ReturnToPool(GameObject obj) =>
            Pool.Add(obj);
    }
}
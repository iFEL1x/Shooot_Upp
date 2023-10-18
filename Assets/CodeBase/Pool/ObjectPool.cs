using CodeBase.Controllers;
using System.Collections.Generic;
using UnityEngine;

namespace CodeBase.Pool
{
    public class ObjectPool : MonoBehaviour
    {
        protected static List<GameObject> Pool;

        [SerializeField] private List<GameObject> _prefabs;
        [SerializeField] private int[] _sizePool;

        protected virtual void Start()
        {
            Pool = new List<GameObject>();
            CreatePool();
        }

        private void CreatePool()
        {
            if (_prefabs == null || _sizePool == null) return;
            if (_prefabs.Count != _sizePool.Length)
            {
                Debug.LogWarning($"Size not specified for {_prefabs[^1].name}");
                return;
            }
            
            for (int j = 0; j < _prefabs.Count; j++)
            {
                GameObject prefab = _prefabs[j];
                int size = _sizePool[j];
                
                for (int i = 0; i < size; i++)
                {
                    GameObject obj = Instantiate(prefab, transform.position, Quaternion.identity);
                    obj.SetActive(false);
                    Pool.Add(obj);
                }
            }
        }
    }
}
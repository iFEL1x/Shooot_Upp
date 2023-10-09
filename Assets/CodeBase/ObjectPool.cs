using System.Collections.Generic;

using UnityEngine;

namespace CodeBase
{
    public class ObjectPool : MonoBehaviour
    {
        protected static GameObject[] ObjectsPool;

        [SerializeField] private GameObject _prefab;
        [SerializeField] private int _sizePool;

        private void Start()
        {
            CreatePool();
        }

        private void CreatePool()
        {
            ObjectsPool = new GameObject[_sizePool];

            for (int i = 0; i < _sizePool; i++)
            {
                GameObject obj = Instantiate(_prefab, transform.position, Quaternion.identity);
                obj.SetActive(false);
                ObjectsPool[i] = obj;
            }
        }
    }
}
using UnityEngine;
using CodeBase.Pool;
using CodeBase.Utils;

namespace CodeBase
{
    public class Spawner : ObjectPool
    {
        [SerializeField] private LevelTemplate[] _levels;
        [SerializeField] private LayerMask _ignoreLayer;

        private BoxCollider2D _collider;

        protected override void Start()
        {
            base.Start();
            _collider = GetComponent<BoxCollider2D>();
        }
        
        private void LateUpdate() =>
            SpawnObjectsForLvl();

        private void SpawnObjectsForLvl()
        {
            if (!Physics2D.OverlapBox(_collider.bounds.center, _collider.bounds.size, 0f, _ignoreLayer))
            {
                GameObject[] objects = _levels[Random.Range(0, _levels.Length)].Objects;

                for (int i = 0; i < objects.Length; i++)
                {
                    if (Pool.Count == 0)
                    {
                        Debug.LogWarning($"Pool is empty, need to increase the pool.");
                        return;
                    }
      
                    GameObject obj = Pool.Find(obj => obj.CompareTag(objects[i].tag));
                    
                    if (obj)
                    {
                        Pool.RemoveAt(0);
                        obj.transform.position = objects[i].transform.position;
                        obj.transform.rotation = objects[i].transform.rotation;
                        obj.SetActive(true);
                    }
                }
            }
        }
    }
}
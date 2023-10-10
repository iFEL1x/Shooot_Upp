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
        
        private void LateUpdate()
        {
            SpawnObjectsForLvl();
        }

        private void SpawnObjectsForLvl()
        {
            if (!Physics2D.OverlapBox(_collider.bounds.center, _collider.bounds.size, 0f, _ignoreLayer))
            {
                Transform[] objects = _levels[Random.Range(0, _levels.Length)].Objects;

                for (int i = 0; i < objects.Length; i++)
                {
                    if (Pool.Count == 0)
                    {
                        Debug.LogWarning($"Pool is empty, need to increase the pool.");
                        return;
                    }

                    var obj = Pool[0];

                    Pool.RemoveAt(0);
                    obj.transform.position = objects[i].position;
                    obj.transform.rotation = objects[i].rotation;
                    obj.SetActive(true);
                }
            }
        }
    }
}
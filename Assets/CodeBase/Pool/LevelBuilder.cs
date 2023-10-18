using UnityEngine;
using Random = UnityEngine.Random;

namespace CodeBase.Pool
{
    public class LevelBuilder : ObjectPool
    {
        [SerializeField] private LevelPattern[] _levels;
        [SerializeField] private LayerMask _ignoreLayer;

        private BoxCollider2D _collider;

        protected override void Start()
        {
            base.Start();
            _collider = GetComponent<BoxCollider2D>();
            SpawnObjectsToLevel();
        }

        private void OnTriggerExit2D(Collider2D other) =>
            SpawnObjectsToLevel();

        private void SpawnObjectsToLevel()
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
                        Pool.Remove(obj);
                        obj.transform.position = objects[i].transform.position;
                        obj.transform.rotation = objects[i].transform.rotation;
                        obj.SetActive(true);
                    }
                    else
                    {
                        Debug.LogWarning($"Object with tag {objects[i]}, not found");
                        return;
                    }
                }
            }
        }
        
        public void ReturnToPool(GameObject obj)
        {
            obj.SetActive(false);
            Pool.Add(obj);
        }
    }
}
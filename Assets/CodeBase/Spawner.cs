using UnityEngine;

namespace CodeBase
{
    public class Spawner : ObjectPool
    {
        [SerializeField] private LevelSample[] _levels;
        private int _loadedLevel;
        private bool _currentLevelEmpty;

        private void Update()
        {
            if (!_currentLevelEmpty)
            {
                Transform[] level = _levels[0].Objects;
                for (int i = 0; i < level.Length; i++)
                {
                    var obj = ObjectsPool[i];
                    
                    if(!obj.activeInHierarchy)
                    {
                        obj.SetActive(true);
                        obj.transform.position = level[i].position;
                        obj.transform.rotation = level[i].rotation;
                    }
                }

                _loadedLevel++;
                _currentLevelEmpty = true;
            }
        }
    }
}
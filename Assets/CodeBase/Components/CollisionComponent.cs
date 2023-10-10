using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CodeBase.Pool;


namespace CodeBase.Components
{
    public class CollisionComponent : MonoBehaviour
    {
        [SerializeField] private List<string> _name;
        private ObjectPool _pool;

        private void Start()
        {
            _pool = FindObjectOfType<ObjectPool>();
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if(_name.Contains(other.tag))
            {
                other.gameObject.SetActive(false);
                _pool.ReturnToPool(other.gameObject);
            }
            else if(other.CompareTag("Player"))
            {
                var scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
        }
    }
}

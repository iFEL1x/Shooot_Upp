using UnityEngine;

namespace CodeBase.Player
{
    public class ShotParticles : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private GameObject _particlePosition;
        
        private ParticleSystem _particle;

        private void Start()
        {
            _particle = _prefab.GetComponent<ParticleSystem>();
        }

        public void Shot()
        {
            
            _prefab.transform.position = _particlePosition.transform.position;
            _prefab.transform.rotation = _particlePosition.transform.rotation;
            _particle.Play();
        }
    }
}

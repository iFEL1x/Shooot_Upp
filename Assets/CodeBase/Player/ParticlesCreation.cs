using UnityEngine;

namespace CodeBase.Player
{
    public class ParticlesCreation : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private GameObject _particlePosition;
        
        private ParticleSystem _particle;

        private void Start() =>
            _particle = Instantiate(_prefab).GetComponent<ParticleSystem>();

        public void Shot()
        {
            _particle.Stop();
            _particle.transform.position = _particlePosition.transform.position;
            _particle.transform.rotation = _particlePosition.transform.rotation;
            _particle.Play();
        }
    }
}

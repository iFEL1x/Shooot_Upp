using UnityEngine;

namespace CodeBase.Handler
{
    public class CooldownReload : MonoBehaviour
    {
        [SerializeField] [Range(1f, 2f)]private float _timeCooldown;
        private float _timesUp;
        public bool IsReady => _timesUp <= Time.time;

        private void Start()
        {
            if (_timeCooldown <= 0)
                _timeCooldown = 1.5f;
        }

        public void Reset() =>
            _timesUp = Time.time + _timeCooldown;
    }
}

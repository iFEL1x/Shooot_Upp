using UnityEngine;

namespace CodeBase.Player
{
    public class ReloadCooldown
    {
        private float _timeCooldown;
        private float _timesUp;
        public ReloadCooldown(float timeCooldown)
        {
            _timeCooldown = timeCooldown;
        }

        public bool IsReady => _timesUp <= Time.time;

        private void Start()
        {
            if (_timeCooldown <= 0)
                _timeCooldown = 1.5f;
        }

        public void Reset(float time) =>
            _timesUp = time + _timeCooldown;
    }
}

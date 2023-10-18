using UnityEngine;

namespace CodeBase.Player.Controllers
{
    public class RotationController
    {
        private readonly float _maxAngularVelocity;
        private readonly Rigidbody2D _rigidbody;
        public RotationController(Rigidbody2D rigidbody, float maxAngularVelocity)
        {
            _rigidbody = rigidbody;
            _maxAngularVelocity = maxAngularVelocity;
        }

        public void RotationControl()
        {
            if (_rigidbody.angularVelocity < -_maxAngularVelocity 
                || _rigidbody.angularVelocity > _maxAngularVelocity)
                _rigidbody.angularVelocity *= 0.5f;
        }
    }
}
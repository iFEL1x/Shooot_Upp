using UnityEngine;

namespace CodeBase.Components
{
    public class ControlRotationComponent : MonoBehaviour
    {
        private Rigidbody2D _rigidbody;

        public float MaxAngularVelocity { get; set; }

        private void Awake() =>
            _rigidbody = GetComponent<Rigidbody2D>();

        private void FixedUpdate() =>
            ControlAngleRotation();

        private void ControlAngleRotation()
        {
            if (_rigidbody.angularVelocity < -MaxAngularVelocity 
                || _rigidbody.angularVelocity > MaxAngularVelocity)
                _rigidbody.angularVelocity *= 0.5f;
        }
    }
}
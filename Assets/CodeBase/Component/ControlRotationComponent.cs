using UnityEngine;

namespace CodeBase.Component
{
    public class ControlRotationComponent : MonoBehaviour
    {
        private float _maxAngularVelocity;
        private Rigidbody2D _rigidbody;

        public float MaxAngularVelocity
        {
            set { _maxAngularVelocity = value; }
        }
        
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
        
        private void FixedUpdate()
        {
            ControlAngleRotation();
        }
        
        private void ControlAngleRotation()
        {
            if (_rigidbody.angularVelocity < -_maxAngularVelocity 
                || _rigidbody.angularVelocity > _maxAngularVelocity)
                _rigidbody.angularVelocity *= 0.5f;
        }
    }
}
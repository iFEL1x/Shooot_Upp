using UnityEngine;

namespace CodeBase.Component
{
    public class ControlRotationComponent : MonoBehaviour
    {
        private Rigidbody2D _rb;
        
        
        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
        
        private void FixedUpdate()
        {
            ControlAngleRotation();
        }
        
        private void ControlAngleRotation()
        {
            if (_rb.angularVelocity is < -300 or > 300)
                _rb.angularVelocity *= 0.5f;
        }
    }
}
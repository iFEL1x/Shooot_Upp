using UnityEngine;

namespace CodeBase.Component
{
    public class ControlReflectionComponent : MonoBehaviour
    {
        protected Rigidbody2D _rigidbody;
        protected const float RightPosition = 7.9f;
        protected const float LeftPosition = -7.9f;
        private const float MaxRightPosition = 15;
        private const float MaxLeftPosition = -15f;
        
        protected virtual void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        protected virtual void FixedUpdate()
        {
            ControlClonePositionX();
        }
        
        private void ControlClonePositionX()
        {
            if (_rigidbody.position.x > MaxRightPosition)
                SetPositionX(LeftPosition);
            else if (_rigidbody.position.x < MaxLeftPosition) 
                SetPositionX(RightPosition);
        }
        
        protected virtual void SetPositionX(float newPositionX)
        {
            _rigidbody.position = new Vector3(
                _rigidbody.position.x + newPositionX,
                _rigidbody.position.y);
        }
    }
}
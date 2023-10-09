using UnityEngine;

namespace CodeBase.Component
{
    public class ControlReflectionComponent : MonoBehaviour
    {
        private Rigidbody2D _rigidbody;
        protected const float RightPosition = 4.25f;
        protected const float LeftPosition = -4.25f;
        protected const float MaxRightPosition = 8.5f;
        protected const float MaxLeftPosition = -8.4f;


        protected virtual void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        protected virtual void Update()
        {
            ControlClonePositionX();
        }
        
        private void ControlClonePositionX()
        {
            if (transform.position.x > RightPosition)
                SetPositionX(LeftPosition);
            else if (transform.position.x < LeftPosition) 
                SetPositionX(RightPosition);
        }
        
        protected virtual void SetPositionX(float newPositionX)
        {
            _rigidbody.position = new Vector3(
                newPositionX, 
                _rigidbody.position.y);
        }
    }
}
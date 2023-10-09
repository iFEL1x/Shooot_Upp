using UnityEngine;

namespace CodeBase.Component
{
    public class ControlReflectionComponent : MonoBehaviour
    {
        protected const float RightPosition = 7.9f;
        protected const float LeftPosition = -7.9f;
        private const float MaxRightPosition = 15;
        private const float MaxLeftPosition = -15f;
        
        private void FixedUpdate()
        {
            ControlClonePositionX();
        }
        
        private void ControlClonePositionX()
        {
            if (transform.position.x > MaxRightPosition)
                SetPositionX(LeftPosition);
            else if (transform.position.x < MaxLeftPosition) 
                SetPositionX(RightPosition);
        }
        
        protected virtual void SetPositionX(float newPositionX)
        {
            Vector3 position = transform.position;
            position.x += newPositionX;
            transform.position = position;
        }
    }
}
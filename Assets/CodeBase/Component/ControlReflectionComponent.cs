using UnityEngine;

namespace CodeBase.Component
{
    public class ControlReflectionComponent : MonoBehaviour
    {
        [SerializeField] protected float _rightPosition;
        [SerializeField] protected float _leftPosition;
        [SerializeField] private float _maxRightPosition;
        [SerializeField] private float _maxLeftPosition;
        
        private void FixedUpdate()
        {
            ControlClonePositionX();
        }
        
        private void ControlClonePositionX()
        {
            if (transform.position.x > _maxRightPosition)
                SetPositionX(_leftPosition);
            else if (transform.position.x < _maxLeftPosition) 
                SetPositionX(_rightPosition);
        }
        
        protected virtual void SetPositionX(float newPositionX)
        {
            Vector3 position = transform.position;
            position.x += newPositionX;
            transform.position = position;
        }
    }
}
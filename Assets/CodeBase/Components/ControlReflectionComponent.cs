using UnityEngine;

namespace CodeBase.Components
{
    public class ControlReflectionComponent : MonoBehaviour
    {
        protected const float RightScreen = 4f;
        protected const float LeftScreen = -4f;
        private Rigidbody2D _rigidbody;


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
            if (transform.position.x > RightScreen)
                SetPositionX(LeftScreen);
            else if (transform.position.x < LeftScreen) 
                SetPositionX(RightScreen);
        }
        
        protected virtual void SetPositionX(float newPositionX)
        {
            _rigidbody.position = new Vector3(
                newPositionX, 
                _rigidbody.position.y);
        }
    }
}
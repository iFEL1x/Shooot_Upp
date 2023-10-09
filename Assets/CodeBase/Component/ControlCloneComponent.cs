using UnityEngine;

namespace CodeBase.Component
{
    public class ControlCloneComponent : ControlReflectionComponent
    {
        public bool _isLeft;
        
        private Rigidbody2D _parentRigidbody;
        private Vector2 _newPosition;
        private float _fixPositionX;
        
        protected override void Start()
        {
            base.Start();
            
            _parentRigidbody = FindObjectOfType<CloneCreation>()
                .GetComponent<Rigidbody2D>();
            
            _fixPositionX = _isLeft ? LeftPosition : RightPosition;
        }
                
        protected override void FixedUpdate()
        {
            base.FixedUpdate();
            
            _newPosition = new Vector2(
                _parentRigidbody.position.x + _fixPositionX, 
                _parentRigidbody.position.y);
            
            _rigidbody.position = _newPosition;
            _rigidbody.rotation = _parentRigidbody.rotation;
        }

        protected override void SetPositionX(float newPositionX)
        {
            if (_parentRigidbody.position.x < LeftPosition)
                _fixPositionX = Mathf.Abs(_fixPositionX * 2);
            else if (_parentRigidbody.position.x > RightPosition)
                _fixPositionX *= -2;
            else
                _fixPositionX = _isLeft ? LeftPosition : RightPosition;
        }
    }
}
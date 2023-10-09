using UnityEngine;

namespace CodeBase.Component
{
    public class ControlCloneComponent : ControlReflectionComponent
    {
        private Transform _parentTransform;
        private Vector2 _newPosition;
        private float _fixPositionX;
        
        protected override void Start()
        {
            _parentTransform = FindObjectOfType<CloneCreation>()
                .GetComponent<Transform>();
            
            _fixPositionX = MaxLeftPosition;
        }
                
        protected override void Update()
        {
            base.Update();
            UpdatePosition();
        }

        private void UpdatePosition()
        {
            _newPosition = new Vector2(
                _parentTransform.position.x + _fixPositionX,
                _parentTransform.position.y);

            transform.position = _newPosition;
            transform.rotation = _parentTransform.rotation;
        }

        protected override void SetPositionX(float newPositionX)
        {
            if (_parentTransform.position.x < LeftPosition)
                _fixPositionX = MaxRightPosition;
            else if (_parentTransform.position.x > RightPosition)
                _fixPositionX = MaxLeftPosition;
        }
    }
}
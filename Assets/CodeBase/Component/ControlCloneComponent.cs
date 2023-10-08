using UnityEngine;

namespace CodeBase.Component
{
    public class ControlCloneComponent : ControlReflectionComponent
    {
        [SerializeField] private Transform _parent;
        [SerializeField] private bool _isLeft;
        private Vector3 _newPosition;
        private float _fixPositionX;

        private void Start()
        {
            _fixPositionX = _isLeft ? _leftPosition : _rightPosition;
        }
                
        private void Update()
        {
            _newPosition = _parent.position;
            _newPosition.x += _fixPositionX;
            
            transform.position = _newPosition;
            transform.rotation = _parent.rotation;
        }

        protected override void SetPositionX(float newPositionX)
        {
            AdjustmentPosition();
        }

        private void AdjustmentPosition()
        {
            if (_parent.position.x < _leftPosition)
                _fixPositionX = Mathf.Abs(_fixPositionX * 2);
            else if (_parent.position.x > _rightPosition)
                _fixPositionX *= -2;
            else
                _fixPositionX = _isLeft ? _leftPosition : _rightPosition;
        }
    }
}
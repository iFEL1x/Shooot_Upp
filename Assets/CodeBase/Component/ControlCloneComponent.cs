using System;
using UnityEngine;

namespace CodeBase.Component
{
    public class ControlCloneComponent : ControlReflectionComponent
    {
        public bool _isLeft;
        
        private Transform _parent;
        private Vector3 _newPosition;
        private float _fixPositionX;
        
        private void Start()
        {
            _parent = FindObjectOfType<CloneCreation>()
                .GetComponent<Transform>();
            
            _fixPositionX = _isLeft ? LeftPosition : RightPosition;
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
            if (_parent.position.x < LeftPosition)
                _fixPositionX = Mathf.Abs(_fixPositionX * 2);
            else if (_parent.position.x > RightPosition)
                _fixPositionX *= -2;
            else
                _fixPositionX = _isLeft ? LeftPosition : RightPosition;
        }
    }
}
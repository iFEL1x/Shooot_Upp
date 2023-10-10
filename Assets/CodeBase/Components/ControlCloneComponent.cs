﻿using UnityEngine;

namespace CodeBase.Components
{
    public class ControlCloneComponent : ControlReflectionComponent
    {
        private const float RightBehindScreen = 8f;
        private const float LeftBehindScreen = -8f;
        private float _fixPositionX;
        private Transform _parentTransform;
        
        protected override void Start()
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            _parentTransform = player.GetComponent<Transform>();
            
            _fixPositionX = LeftBehindScreen;
        }
                
        protected override void Update()
        {
            base.Update();
            CloneParentPosition();
        }

        private void CloneParentPosition()
        {
            Vector2 newPosition = new Vector2(
                _parentTransform.position.x + _fixPositionX,
                _parentTransform.position.y);

            transform.position = newPosition;
            transform.rotation = _parentTransform.rotation;
        }

        protected override void SwitchPositionX(float newPositionX)
        {
            if (_parentTransform.position.x < LeftScreen + 1f)
                _fixPositionX = RightBehindScreen;
            else if (_parentTransform.position.x > RightScreen - 1f)
                _fixPositionX = LeftBehindScreen;
        }
    }
}
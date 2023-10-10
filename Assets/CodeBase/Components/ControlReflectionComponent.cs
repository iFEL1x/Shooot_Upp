﻿using UnityEngine;

namespace CodeBase.Components
{
    public class ControlReflectionComponent : MonoBehaviour
    {
        protected const float RightScreen = 4f;
        protected const float LeftScreen = -4f;
        private Rigidbody2D _rigidbody;


        protected virtual void Start() =>
            _rigidbody = GetComponent<Rigidbody2D>();

        protected virtual void Update() =>
            ControlPositionX();

        private void ControlPositionX()
        {
            if (transform.position.x > RightScreen)
                SwitchPositionX(LeftScreen);
            else if (transform.position.x < LeftScreen) 
                SwitchPositionX(RightScreen);
        }
        
        protected virtual void SwitchPositionX(float newPositionX)
        {
            _rigidbody.position = new Vector3(
                newPositionX, 
                _rigidbody.position.y);
        }
    }
}
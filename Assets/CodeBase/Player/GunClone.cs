using UnityEngine;

namespace CodeBase.Player
{
    public class GunClone : Gun
    {
        private float _fixPositionX;
        private Transform _parentTransform;
        
        public GameObject Gun { get; set; }
        
        protected override void Start()
        {
            _parentTransform = Gun.GetComponent<Transform>();
            _fixPositionX = RightScreen * 2f;
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

        protected override void ControlPositionX()
        {
            if (_parentTransform.position.x < LeftScreen + 1f)
                SwitchPositionX(RightScreen);
            else if (_parentTransform.position.x > RightScreen - 1f)
                SwitchPositionX(LeftScreen);
        }

        protected override void SwitchPositionX(float newPositionX)
        {
            _fixPositionX = newPositionX * 2f;
        }
    }
}
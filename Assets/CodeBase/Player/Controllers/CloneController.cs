using UnityEngine;

namespace CodeBase.Player.Controllers
{
    public class CloneController : ScreenPositionController
    {
        [HideInInspector] public Transform PlayerTransform;
        [HideInInspector] public float DistanceFromPlayer;
        private float _fixPositionX;
        
        protected override void Start() =>
            _fixPositionX = edgeScreen * 2f;

        protected override void Update()
        {
            base.Update();
            CloneParentPosition();
        }

        private void CloneParentPosition()
        {
            Vector2 newPosition = new Vector2(
                PlayerTransform.position.x + _fixPositionX,
                PlayerTransform.position.y);

            transform.position = newPosition;
            transform.rotation = PlayerTransform.rotation;
        }

        protected override void ControlPositionX()
        {
            if (PlayerTransform.position.x < -edgeScreen + DistanceFromPlayer)
                SwitchPositionX(edgeScreen);
            else if (PlayerTransform.position.x > edgeScreen - DistanceFromPlayer)
                SwitchPositionX(-edgeScreen);
        }

        protected override void SwitchPositionX(float newPositionX)
        {
            _fixPositionX = newPositionX * 2f;
        }
    }
}
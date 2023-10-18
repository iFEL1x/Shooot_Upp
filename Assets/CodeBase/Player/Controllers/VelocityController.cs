using UnityEngine;

namespace CodeBase.Player.Controllers
{
    public class VelocityController
    {
        private readonly float _maxVelocityX;
        private readonly float _maxVelocityY;
        private readonly Rigidbody2D _rigidbody;
        
        public VelocityController(Rigidbody2D rigidbody, float maxVelocityX, float maxVelocityY)
        {
            _rigidbody = rigidbody;
            _maxVelocityX = maxVelocityX;
            _maxVelocityY = maxVelocityY;
        }

        public void VelocityControl()
        {
            if (_rigidbody.velocity.y > _maxVelocityY)
            {
                _rigidbody.velocity = new Vector2(
                    _rigidbody.velocity.x,
                    _rigidbody.velocity.y * 0.8f);
            }
           
            if (_rigidbody.velocity.x < -_maxVelocityX)
            {
                _rigidbody.velocity = new Vector2(
                    _rigidbody.velocity.x * 0.8f,
                    _rigidbody.velocity.y);
            }
            else if (_rigidbody.velocity.x > _maxVelocityX)
            {
                _rigidbody.velocity = new Vector2(
                    _rigidbody.velocity.x * 0.8f,
                    _rigidbody.velocity.y);
            }
        }
    }
}

using UnityEngine;

namespace CodeBase.Player.Controllers
{
    public class HeightController
    {
        private readonly Rigidbody2D _rigidbody;
        
        public HeightController(Rigidbody2D rigidbody) =>
            _rigidbody = rigidbody;

        public void HeightControl()
        {
            if (_rigidbody.position.y > 2)
                _rigidbody.position = new Vector2(_rigidbody.position.x, 2f);
        }
    }
}
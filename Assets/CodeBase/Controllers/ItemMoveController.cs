using UnityEngine;

namespace CodeBase.Controllers
{
    public class ItemMoveController : MonoBehaviour
    {
        private Rigidbody2D _playerRigidbody;
        private Rigidbody2D _rigidbody;
        private Vector3 _currentPosition;
        private Vector3 _destination;

        private void Awake()
        {
            _playerRigidbody = GameObject.FindGameObjectWithTag("Player")
                .GetComponent<Rigidbody2D>();
            
            _rigidbody = GetComponent<Rigidbody2D>();
        }
        
        private void OnEnable() =>
            _destination = new Vector3(transform.position.x, -15, 1);

        private void FixedUpdate() =>
            Move();

        private void Move()
        {
            _currentPosition = _rigidbody.position;
            
            Vector3 smoothedDelta = Vector3.MoveTowards(
                _currentPosition,
                _destination,
                _playerRigidbody.velocity.y * Time.deltaTime);
            
            _rigidbody.MovePosition(smoothedDelta);
        }
    }
}

using UnityEngine;

namespace CodeBase.Components
{
    public class VerticalMovementComponent : MonoBehaviour
    {
        private Rigidbody2D _gunRigidbody;
        private Rigidbody2D _rigidbody;
        public Vector3 _currentPosition;
        public Vector3 _destination;

        private void Awake()
        {
            _gunRigidbody = GameObject.FindGameObjectWithTag("Player")
                .GetComponent<Rigidbody2D>();
            
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void OnEnable() =>
            _destination = new Vector3(transform.position.x, -15, 1);

        private void FixedUpdate() =>
            Moved();

        private void Moved()
        {
            _currentPosition = _rigidbody.position;
            
            Vector3 smoothedDelta = Vector3.MoveTowards(
                _currentPosition,
                _destination,
                Time.fixedDeltaTime * _gunRigidbody.velocity.y);
            
            _rigidbody.MovePosition(smoothedDelta);
        }
    }
}

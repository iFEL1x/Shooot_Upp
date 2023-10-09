using UnityEngine;

namespace CodeBase.Component
{
    public class VerticalMovementComponent : MonoBehaviour
    {
        private Rigidbody2D _playerRigidbody;

        private void Start()
        {
            _playerRigidbody = FindObjectOfType<CloneCreation>()
                .gameObject.GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            Moved();
        }

        private void Moved()
        {
            transform.Translate(0, _playerRigidbody.velocity.y * -Time.deltaTime, 0);
        }
    }
}

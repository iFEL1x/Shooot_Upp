using UnityEngine;

namespace CodeBase.Components
{
    public class VerticalMovementComponent : MonoBehaviour
    {

        private Rigidbody2D _playerRigidbody;

        private void Start()
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            _playerRigidbody = player.GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate() =>
            Moved();

        private void Moved() =>
            transform.Translate(0, _playerRigidbody.velocity.y * -Time.deltaTime, 0);
    }
}

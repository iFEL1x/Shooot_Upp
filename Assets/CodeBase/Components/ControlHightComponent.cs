using UnityEngine;

namespace CodeBase.Components
{
    public class ControlHightComponent : MonoBehaviour
    {
        private Rigidbody2D _playerRigidbody;
        
        private void Awake() =>
            _playerRigidbody = GetComponent<Rigidbody2D>();

        private void FixedUpdate() =>
            ControlMaxHight();

        private void ControlMaxHight()
        {
            if (transform.position.y > 2)
                _playerRigidbody.position = new Vector2(_playerRigidbody.position.x, 2f);
        }
    }
}
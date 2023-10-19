using UnityEngine;

namespace CodeBase.Player.Components
{
    public class AddBoostComponent : MonoBehaviour
    {
        [SerializeField] private float _force = 10f;
        private const string _TAG_PLAYER = "Player";
        private Rigidbody2D _rigidbody;

        private void Awake() =>
            _rigidbody = GameObject.FindGameObjectWithTag(_TAG_PLAYER).GetComponent<Rigidbody2D>();

        public void Boost() =>
            _rigidbody.AddForce(transform.up * _force, ForceMode2D.Impulse);
    }
}
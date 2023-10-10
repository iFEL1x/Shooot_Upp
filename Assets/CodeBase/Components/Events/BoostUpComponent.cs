using UnityEngine;

namespace CodeBase.Components.Events
{
    public class BoostUpComponent : MonoBehaviour
    {
        [SerializeField] private float _force = 40f;
        [SerializeField] private Rigidbody2D _rigidbody;

        public void Boost(GameObject obj)
        {
            _rigidbody.velocity = Vector2.zero;
            _rigidbody.AddForce(obj.transform.up * _force, ForceMode2D.Impulse);
        }
    }
}

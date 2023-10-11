using UnityEngine;

namespace CodeBase.Player
{
    public class ControlHeight : MonoBehaviour
    {
        protected Rigidbody2D GumRigidbody;
        
        private void Awake() =>
            GumRigidbody = GetComponent<Rigidbody2D>();

        protected virtual void FixedUpdate() =>
            ControlMaxHeight();

        private void ControlMaxHeight()
        {
            if (transform.position.y > 2)
                GumRigidbody.position = new Vector2(GumRigidbody.position.x, 2f);
        }
    }
}
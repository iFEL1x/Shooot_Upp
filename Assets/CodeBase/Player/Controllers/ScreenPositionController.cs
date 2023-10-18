using UnityEngine;

namespace CodeBase.Player.Controllers
{
    public class ScreenPositionController : MonoBehaviour
    {
        [SerializeField] protected float edgeScreen = 4f;
        private Rigidbody2D _rigidbody;

        protected virtual void Start() =>
            _rigidbody = GetComponent<Rigidbody2D>();

        protected virtual void Update() =>
            ControlPositionX();
        
        protected virtual void ControlPositionX()
        {
            if (transform.position.x > edgeScreen)
                SwitchPositionX(-edgeScreen);
            else if (transform.position.x < -edgeScreen) 
                SwitchPositionX(edgeScreen);
        }
        
        protected virtual void SwitchPositionX(float newPositionX)
        {
            _rigidbody.position = new Vector3(
                newPositionX, 
                _rigidbody.position.y);
        }
    }
}
using CodeBase.Component;
using UnityEngine;

namespace CodeBase
{
    public class MoveHandler : MonoBehaviour
    {
        [SerializeField] private float _force;
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private float _maxAngularSpeed;
        
        private Rigidbody2D _rigidbody;
        private ControlRotationComponent _controlRotation;


        private void Awake()
        {
            _rigidbody = FindObjectOfType<CloneCreation>()
                .gameObject.GetComponent<Rigidbody2D>();
            
            _controlRotation = _rigidbody.GetComponent<ControlRotationComponent>();
        }

        private void Start()
        {
            _controlRotation.MaxAngularVelocity = _maxAngularSpeed;
        }

        private void Update()
        {
            if(Input.GetMouseButtonDown(0))
                SetImpulse();
        }
    
        private void SetImpulse()
        {
            _rigidbody.velocity = Vector2.zero;
            _rigidbody.AddForce(_rigidbody.transform.up * _force, ForceMode2D.Impulse);
            _rigidbody.AddTorque(NormalizeRotationZ() * _rotationSpeed, ForceMode2D.Impulse);
        }
    
        private int NormalizeRotationZ() => 
            _rigidbody.transform.rotation.z > 0 ? 1 : -1;
    }
}
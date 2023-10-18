using UnityEngine;
using CodeBase.Player.Controllers;

namespace CodeBase.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _force;
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private float _maxVelocityX;
        [SerializeField] private float _maxVelocityY;
        [SerializeField] private float _maxAngularVelocity = 400f;
        [Range(0.5f, 2f)] 
        [SerializeField] private float _timeCooldown;
        [SerializeField] private float _cloneDistanceFromPlayer = 1f;
        
        private Rigidbody2D _rigidbody;
        private AmmoContainer _ammoContainer;
        private ParticlesCreation _particleCreation;
        private RotationController _rotationController;
        private HeightController _heightController;
        private VelocityController _velocityController;
        private ReloadCooldown _reloadCooldown;
        private CloneCreation _cloneCreation;
        
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _ammoContainer = GetComponent<AmmoContainer>();
            _particleCreation = GetComponent<ParticlesCreation>();

            _reloadCooldown =  new ReloadCooldown(_timeCooldown);
            _rotationController = new RotationController(_rigidbody, _maxAngularVelocity);
            _heightController = new HeightController(_rigidbody);
            _velocityController = new VelocityController(_rigidbody, _maxVelocityX, _maxVelocityY);
            
            _cloneCreation = new CloneCreation(
                new GameObject(),
                transform,
                GetComponent<SpriteRenderer>().sprite,
                _cloneDistanceFromPlayer);
        }

        private void Start() =>
            _cloneCreation.CreateClone();

        private void FixedUpdate()
        {
            _rotationController.RotationControl();
            _heightController.HeightControl();
            _velocityController.VelocityControl();
        }

        private void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                if (_reloadCooldown.IsReady && _ammoContainer.Ammo > 0)
                {
                    SetImpulse();
                    _reloadCooldown.Reset(Time.time);
                    _ammoContainer.Ammo--;
                    _particleCreation.Shot();
                }
                Debug.Log($"Velocity: X = {_rigidbody.velocity.x} Y = {_rigidbody.velocity.y}");
            }
        }
    
        private void SetImpulse()
        {
            if(_rigidbody.velocity.y <= -5f)
                _rigidbody.velocity = Vector2.zero;
            
            _rigidbody.AddForce(transform.up * _force, ForceMode2D.Impulse);
            _rigidbody.AddTorque(NormalizeRotationZ() * _rotationSpeed, ForceMode2D.Impulse);
        }
        
        private int NormalizeRotationZ() => 
            transform.rotation.z > 0 ? 1 : -1;

    }
}
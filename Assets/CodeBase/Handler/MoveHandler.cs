using UnityEngine;
using CodeBase.Player;

namespace CodeBase.Handler
{
    public class MoveHandler : MonoBehaviour
    {
        [SerializeField] private float _force;
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private float _maxAngularSpeed;
        
        private Rigidbody2D _rigidbodyGun;
        private ControlRotation _controlRotationGun;
        private CooldownReload _cooldownReload;
        private AmmoCounter _ammoCounter;
        private ShotParticles _particle;
        
        private void Awake()
        {
            GameObject gun = GameObject.FindGameObjectWithTag("Player");
            _rigidbodyGun = gun.GetComponent<Rigidbody2D>();
            _controlRotationGun = gun.GetComponent<ControlRotation>();
            
            _cooldownReload = GetComponent<CooldownReload>();
            _ammoCounter = GetComponent<AmmoCounter>();
            _particle = GetComponent<ShotParticles>();
        }

        private void Start() =>
            _controlRotationGun.MaxAngularVelocity = _maxAngularSpeed;

        private void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                if (_cooldownReload.IsReady && _ammoCounter.Ammo > 0)
                {
                    SetImpulse();
                    _cooldownReload.Reset();
                    _ammoCounter.Ammo--;
                    _particle.Shot();
                }
            }
        }
    
        private void SetImpulse()
        {
            _rigidbodyGun.velocity = Vector2.zero;
            _rigidbodyGun.AddForce(_rigidbodyGun.transform.up * _force, ForceMode2D.Impulse);
            _rigidbodyGun.AddTorque(NormalizeRotationZ() * _rotationSpeed, ForceMode2D.Impulse);
        }
    
        private int NormalizeRotationZ() => 
            _rigidbodyGun.transform.rotation.z > 0 ? 1 : -1;
    }
}
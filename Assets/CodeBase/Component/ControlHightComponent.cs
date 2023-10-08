using UnityEngine;

namespace CodeBase.Component
{
    public class ControlHightComponent : MonoBehaviour
    {
        public static bool MaxHight;
        
        private Rigidbody2D _rb;

    
        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
        
        private void FixedUpdate()
        {
            ControlMaxHight();
        }
        
        private void ControlMaxHight()
        {
            if (transform.position.y > 2)
            {
                MaxHight = true;
    
                Vector2 maxHight = _rb.position;
                maxHight.y = 2f;
                _rb.position = maxHight;
            }
            else
                MaxHight = false;
        }
    }
}
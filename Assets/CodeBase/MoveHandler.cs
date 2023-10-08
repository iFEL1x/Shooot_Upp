using UnityEngine;

namespace CodeBase
{
    public class MoveHandler : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D[] rbEntityPlayers;
        [SerializeField] private float _force;
        [SerializeField] private float _rotationSpeed;
        
        private void OnMouseDown()
        {
            MoveUp();
        }
    
        private void MoveUp()
        {
            foreach (Rigidbody2D entity in rbEntityPlayers)
            {
                entity.velocity = Vector2.zero;
                entity.AddForce(entity.transform.up * _force, ForceMode2D.Impulse);
                entity.AddTorque(AngeRotation(entity) * _rotationSpeed, ForceMode2D.Impulse);
            }
        }
    
        private int AngeRotation(Rigidbody2D rb) => 
            rb.transform.rotation.z > 0 ? 1 : -1;
    }
}
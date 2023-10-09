using System;
using UnityEngine;

namespace CodeBase.Component
{
    public class MovedComponent : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _playerRigidbody2D;

        private void Awake()
        {
            _playerRigidbody2D = FindObjectOfType<CloneCreation>()
                .gameObject.GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if(_playerRigidbody2D.velocity.y > 0)
                transform.Translate(0, _playerRigidbody2D.velocity.y * -Time.deltaTime, 0);
        }
    }
}

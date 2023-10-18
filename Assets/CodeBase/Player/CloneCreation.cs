using UnityEngine;
using CodeBase.Player.Controllers;

namespace CodeBase.Player
{
    public class CloneCreation
    {
        private GameObject _gameObject;
        private Transform _transformPlayer;
        private Sprite _sprite;
        private float _distanceFromPlayer;
        public CloneCreation(GameObject gameObject, Transform transformPlayer, Sprite sprite, float distanceFromPlayer)
        {
            _gameObject = gameObject;
            _transformPlayer = transformPlayer;
            _sprite = sprite;
            _distanceFromPlayer = distanceFromPlayer;
        }
        
        public void CreateClone()
        {
            _gameObject.name = "playerClone";
            _gameObject.AddComponent<SpriteRenderer>().sprite = _sprite;

            _gameObject.AddComponent<CloneController>();
            CloneController cloneController = _gameObject.GetComponent<CloneController>();
            cloneController.PlayerTransform = _transformPlayer;
            cloneController.DistanceFromPlayer = _distanceFromPlayer;
        }
    }
}
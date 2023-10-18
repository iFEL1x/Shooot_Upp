using UnityEngine;

namespace CodeBase.Pool
{
    public class ReturnToPool : MonoBehaviour
    {
        private const string _TAG_LEVEL_BUILDER = "LevelBuilder";
        private LevelBuilder _levelBuilder;

        private void Awake() =>
            _levelBuilder = GameObject.FindGameObjectWithTag(_TAG_LEVEL_BUILDER).GetComponent<LevelBuilder>();

        public void Return(GameObject obj) =>
            _levelBuilder.ReturnToPool(obj);
    }
}

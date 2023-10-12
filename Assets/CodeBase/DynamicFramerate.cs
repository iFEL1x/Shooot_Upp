using UnityEngine;

namespace CodeBase
{
    public class DynamicFramerate : MonoBehaviour
    {
        private void Start() =>
            Application.targetFrameRate = 60;
    }
}

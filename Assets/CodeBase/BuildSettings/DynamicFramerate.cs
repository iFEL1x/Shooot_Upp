using UnityEngine;

namespace CodeBase.BuildSettings
{
    public class DynamicFramerate : MonoBehaviour
    {
        private void Start() =>
            Application.targetFrameRate = 60;
    }
}

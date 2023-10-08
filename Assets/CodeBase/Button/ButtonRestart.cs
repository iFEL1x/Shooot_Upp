using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeBase.Button
{
    public class ButtonRestart : MonoBehaviour
    {
        public void Restart()
        {
            var scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeBase.Button
{
    public class RestartLevel : MonoBehaviour
    {
        public void Restart()
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
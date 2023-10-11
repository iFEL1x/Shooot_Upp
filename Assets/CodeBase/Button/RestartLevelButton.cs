using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeBase.Button
{
    public class RestartLevelButton : MonoBehaviour
    {
        public void Restart()
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
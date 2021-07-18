using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButtonScript : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

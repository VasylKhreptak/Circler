using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenuScript : MonoBehaviour
{
    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}

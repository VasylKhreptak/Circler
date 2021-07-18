using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ShowRestartMenuBackgroundSprite;
    public GameObject restartButton, watchAddButton;

    public ParticleSystem finishLineParticle;
    public Text NumberOfCoins;

    public GameObject Player;
    public ScoreController scoreController;

    public GameObject obstacle;

    public GameObject shopCanvas;

    public void ShowRestartMenu(bool isShown)
    {
        ShowRestartMenuBackgroundSprite.SetActive(isShown);

        restartButton.SetActive(isShown);
        restartButton.transform.Find("Text").gameObject.SetActive(isShown);

        watchAddButton.SetActive(isShown);
        watchAddButton.transform.Find("Text").gameObject.SetActive(isShown);

    }
    public void RestartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void CircleComplete(int score)
    {
        NumberOfCoins.text = (int.Parse(NumberOfCoins.text) + 50 + 10 * score).ToString();
        finishLineParticle.Play();
        PlayerPrefs.SetInt("Coins", int.Parse(NumberOfCoins.text));
    }
    public void RestoreScore()
    {
        ShowRestartMenu(false);

        obstacle.SetActive(false);
        obstacle.transform.rotation = Quaternion.Euler(0, 0, 317);

        obstacle.SetActive(true);

        Player.SetActive(true);
        Player.transform.localPosition = new Vector2();
        Player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;

        scoreController.ShowScore();
    }
    public void HideShop()
    {
        shopCanvas.SetActive(false);
    }
    public void ShowShop()
    {
        shopCanvas.SetActive(true);
    }
}

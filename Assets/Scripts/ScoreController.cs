using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    public uint score;

    public void ShowScore()
    {
        scoreText.text = "Score " + score.ToString();
    }
    public void ShowRecord()
    {
        scoreText.text = "Record " + PlayerPrefs.GetInt("Record").ToString();

        gameObject.SetActive(false);
        gameObject.SetActive(true);
    }
}

using UnityEngine;
using UnityEngine.UI;

public class LoadGameInfo : MonoBehaviour
{
    public Sprite soundOn;
    public Sprite soundOff;
    public Button soundControllButton;
    public AudioSource playerAudioSource;

    public Text NumberOfCoins;

    public ScoreController scoreController;
    void Start()
    {
        NumberOfCoins.text = PlayerPrefs.GetInt("Coins").ToString();

        if (PlayerPrefs.GetInt("isSoundEnabled") == 1)
        {
            soundControllButton.image.sprite = soundOn;
            playerAudioSource.enabled = true;
        }
        else
        {
            soundControllButton.image.sprite = soundOff;
            playerAudioSource.enabled = false;
        }

        scoreController.ShowRecord();
    }
}

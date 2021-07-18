using UnityEngine;
using UnityEngine.UI;

public class SoundControlButton : MonoBehaviour
{
    public Sprite soundOn;
    public Sprite soundOff;
    public AudioSource sound;

    public void ChangeTheAudioLevel()
    {
        if (sound.enabled)
        {
            sound.enabled = false;
            GetComponent<Image>().sprite = soundOff;
            PlayerPrefs.SetInt("isSoundEnabled", 0);
        }
        else
        {
            sound.enabled = true;
            GetComponent<Image>().sprite = soundOn;
            PlayerPrefs.SetInt("isSoundEnabled", 1);
        }

    }
}

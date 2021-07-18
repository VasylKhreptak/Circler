using UnityEngine;
using UnityEngine.UI;

public class LoadCoins : MonoBehaviour
{
    public Text NumberOfCoins;
    void Start()
    {
        NumberOfCoins.text = PlayerPrefs.GetInt("Coins").ToString();
    }
}

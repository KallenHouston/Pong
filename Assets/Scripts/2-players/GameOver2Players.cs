using UnityEngine;
using UnityEngine.UI;

public class GameOver2Players : MonoBehaviour
{
    public Text winnerText;

    void Start()
    {
        string winner = PlayerPrefs.GetString("Winner");
        winnerText.text = winner + " wins!";
    }
}

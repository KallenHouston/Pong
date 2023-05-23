using UnityEngine;
using UnityEngine.UI;

public class GameOver1Player : MonoBehaviour
{
    public Text winnerText;

    void Start()
    {
        string winner = PlayerPrefs.GetString("Winner");
        winnerText.text = winner + " wins!";
    }
}

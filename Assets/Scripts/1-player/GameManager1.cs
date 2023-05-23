using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour
{
    [SerializeField] private int winScore;
    private int _PlayerScore;
    private int _BotScore;
    public BallMovement ball;
    public Paddle playerPaddle;
    public Paddle botPaddle;
    public Text playerScore;
    public Text botScore;

    public void PlayerScore()
    {
        _PlayerScore++;
        playerScore.text = _PlayerScore.ToString();
        ScoreCheck();
        RoundReset();
    }

    public void BotScore()
    {
        _BotScore++;
        botScore.text = _BotScore.ToString();
        ScoreCheck();
        RoundReset();
    }

    private void RoundReset()
    {
        ball.ResetPos();
        playerPaddle.ResetPos();
        botPaddle.ResetPos();
        ball.StartingForce();
    }

    private void ScoreCheck()
    {
        if (_PlayerScore == winScore)
        {
            SceneManager.LoadScene("GameOverPlayer", new LoadSceneParameters(LoadSceneMode.Single));
            PlayerPrefs.SetString("Winner", "Player");
        }
        else if (_BotScore == winScore)
        {
            SceneManager.LoadScene("GameOverPlayer", new LoadSceneParameters(LoadSceneMode.Single));
            PlayerPrefs.SetString("Winner", "Bot");
        }
    }
}
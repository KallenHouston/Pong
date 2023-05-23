using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    [SerializeField] private int winScore;
    private int _Player1Score;
    private int _Player2Score;
    public BallMovement ball;
    public Paddle player1Paddle;
    public Paddle player2Paddle;
    public Text player1Score;
    public Text player2Score;

    public void Player1Score()
    {
        _Player1Score++;
        player1Score.text = _Player1Score.ToString();
        ScoreCheck();
        RoundReset();
    }

    public void Player2Score()
    {
        _Player2Score++;
        player2Score.text = _Player2Score.ToString();
        ScoreCheck();
        RoundReset();
    }

    private void RoundReset()
    {
        ball.ResetPos();
        player1Paddle.ResetPos();
        player2Paddle.ResetPos();
        ball.StartingForce();
    }

    private void ScoreCheck()
    {
        if (_Player1Score == winScore)
        {
            SceneManager.LoadScene("GameOver2Players", new LoadSceneParameters(LoadSceneMode.Single));
            PlayerPrefs.SetString("Winner", "Player 1");
        }
        else if (_Player2Score == winScore)
        {
            SceneManager.LoadScene("GameOver2Players", new LoadSceneParameters(LoadSceneMode.Single));
            PlayerPrefs.SetString("Winner", "Player 2");
        }
    }
}

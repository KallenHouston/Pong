using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
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
        this.playerScore.text = _PlayerScore.ToString();
        ScoreCheck();
        RoundReset();
    }

    public void BotScore() 
    {
        _BotScore++;
        this.botScore.text = _BotScore.ToString();
        ScoreCheck();
        RoundReset();
    }

    private void RoundReset()
    {
        this.ball.ResetPos();
        this.playerPaddle.ResetPos();
        this.botPaddle.ResetPos();
        this.ball.StartingForce();
    }

    private void ScoreCheck()
    {
        if(_PlayerScore == winScore || _BotScore == winScore)
        {
            SceneManager.LoadScene(2);
        }
    }    
}

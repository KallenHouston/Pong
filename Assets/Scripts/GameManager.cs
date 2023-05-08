using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
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
        RoundReset();
    }

    public void BotScore() 
    {
        _BotScore++;
        this.botScore.text = _BotScore.ToString();
        RoundReset();
    }

    private void RoundReset()
    {
        this.ball.ResetPos();
        this.playerPaddle.ResetPos();
        this.botPaddle.ResetPos();
        this.ball.StartingForce();
    }
}

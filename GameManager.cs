using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public LeftPaddle leftPaddle;
    public ComputerPaddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;
    private int playerScore;
    private int computerScore;

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        ResetLevel();
    }

    public void ComputerScores()
    {
        computerScore++;
        computerScoreText.text = computerScore.ToString();
        ResetLevel();
    }

    private void ResetLevel()
    {
        leftPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }
}

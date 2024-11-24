using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    private int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}

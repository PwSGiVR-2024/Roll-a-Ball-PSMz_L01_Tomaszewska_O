using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text winText;
    private int score = 0;

    void Start()
    {
        UpdateScoreText();
        winText.gameObject.SetActive(false);
    }

    public void AddPoint()
    {
        score++;
        UpdateScoreText();
        EndGameCheck();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
    private void EndGameCheck()
    {
        if (score >= 5)
        {
            winText.gameObject.SetActive(true);
            winText.text = "You win!";
            NextScene();
        }
    }
    private void NextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}

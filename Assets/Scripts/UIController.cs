using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class UIController : MonoBehaviour
{
    //Reference to Canvas
    public GameObject canvas;
    TMP_Text scoreText;
    private int playerScore = 0;

    private void OnEnable()
    {
        CollisionController.OnGameOverEvent += GameOverPanel;
        CollisionController.ScoreUpdation += UpdateScoreInUI;

    }
    private void OnDisable()
    {
       CollisionController.OnGameOverEvent -= GameOverPanel;
       CollisionController.ScoreUpdation -= UpdateScoreInUI;
    }


    private void Start()
    {
        scoreText = FindObjectOfType<TMP_Text>();
    }

    private void Update()
    {
       
    }
    //Restart Game
    public void RestartGame()
    {
        SceneManager.LoadScene("MyScene");
    }
     
    //Display Game Over Panel
    void GameOverPanel(bool isGameOver)
    {
        if (isGameOver)
        {
            canvas.SetActive(true);
        }

    }

    //Score Increment
     void UpdateScoreInUI()
    {
        playerScore++;
        scoreText.text = "Score : " + playerScore.ToString();
       
    }

    // Quit Game 
    public void QuitGame()
    {
        Application.Quit();
    }
}

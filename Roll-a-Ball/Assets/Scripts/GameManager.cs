using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
     #region Variables
     public static int score;
     public TextMeshProUGUI scoreText;
     public GameObject victoryTextObject;
     public GameObject gameOverTextObject; 
     private bool GameHasEnded = false;
     public float restartDelay = 2f;
     #endregion

    void Start()
   {
        score = 0;
        UpdateUI();
        victoryTextObject.SetActive(false);
        gameOverTextObject.SetActive(false);
   }

   public void UpdateScore(int amount)
   {
        score += amount;
        UpdateUI();

        if(score >= 10)
        {
          WinGame();
        }
   }

   public void UpdateUI()
   {
     scoreText.text = score.ToString();
   }

   public void WinGame()
   {
        victoryTextObject.SetActive(true);
   }

   public void EndGame()
   {
     if (!GameHasEnded) 
     {
          gameOverTextObject.SetActive(true);
          GameHasEnded = true;
          Invoke("RestartLevel", restartDelay);
     }
   }

   private void RestartLevel()
   {
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}

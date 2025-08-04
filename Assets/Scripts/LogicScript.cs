using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
   public int playerScore;
   public Text playerScoreText;
   public GameObject gameOverScreen;

   [ContextMenu("Increase Score")]
   public void AddScore(int scoreToAdd)
   {
      playerScore += scoreToAdd;
      playerScoreText.text = playerScore.ToString();
   }

   public void restartGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   public void gameOver()
   {
      gameOverScreen.SetActive(true);
   }
   
}

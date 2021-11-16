
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public RestartButton GameOverScreen;
    bool isGameEnded = false;
   
    public void GameOver()
    {
        if(isGameEnded==false)
        {
            isGameEnded=true;
            Debug.Log("game over");
            gameObject.SetActive(true);
            GameOverScreen.Setup(ScoreMenager.instance.setScore());
            
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ExitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

}

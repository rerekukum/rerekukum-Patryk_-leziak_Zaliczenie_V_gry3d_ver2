
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameEnded = false;
    public GameObject gameObject;
    public void GameOver()
    {
        if(isGameEnded==false)
        {
            isGameEnded=true;
            Debug.Log("game over");
            gameObject.SetActive(true);
            
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public PlayerController movement;

    public void restartButton()
    {
        FindObjectOfType<GameManager>().Restart();
    }
    public void exitButton()
    {
        FindObjectOfType<GameManager>().ExitGame();
    }
}

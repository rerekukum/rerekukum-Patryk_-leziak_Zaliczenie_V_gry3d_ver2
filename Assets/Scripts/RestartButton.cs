using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public PlayerController movement;

    public Text pointsText;
    
    public bool isEnded=false;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " Points";
    }

    public void restartButton()
    {
        FindObjectOfType<GameManager>().Restart();
    }
    public void exitButton()
    {
        FindObjectOfType<GameManager>().ExitGame();
    }
}

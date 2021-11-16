using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreMenager : MonoBehaviour
{

    public  static ScoreMenager instance;
    public RestartButton GameOverScreen;
   
    public TextMeshProUGUI text;
    public  int score=0;

    // Start is called before the first frame update
    void Start()
    {
        if(instance==null){
            instance = this;
        }
    }

    public void ChangeScore(int coinValue){
        score+=coinValue;
        text.text="X"+score.ToString();
        

    }

    public int setScore()
    {
        return this.score;
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreMenager : MonoBehaviour
{

    public static ScoreMenager instance;
    public TextMeshProUGUI text;
    int score;

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

    // Update is called once per frame
    void Update()
    {
        
    }
}

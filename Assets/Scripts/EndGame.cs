using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public TextMeshProUGUI TimeText;
    public TextMeshProUGUI ScoresText;
    // private string time = "" + Convert.ToInt32(ScriptCalculation.timeUsed) + "s";
    private int scores = ScriptCalculation.score;
    // Score thresholds
    private int twoStar = 1000;
    private int oneStar = 500;

    public Image Background;
    public Sprite GOOD, GREAT, EXCELLENT;
    // Start is called before the first frame update
    void Start()
    {
        initiateBackground();
        SetText();
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void returnToMenu(){
        SceneManager.LoadScene("StartMenu");
    }

    public void playAgain(){
        if(Connect.pieceNum == 12){
            SceneManager.LoadScene("12Pieces");
        }
        if(Connect.pieceNum == 9){
            SceneManager.LoadScene("9Pieces");
        }
    }

    void initiateBackground(){
        if(scores >= twoStar){
            Background.sprite = EXCELLENT;
        }
        else if (scores >= oneStar){
            Background.sprite = GREAT;
        } 
        else {
            Background.sprite = GOOD;
        }
    }

    void SetText()
    {
        var minutes = (int) (ScriptCalculation.timeUsed / 60);
        var minute = minutes.ToString() + "m";
        var second = (int) (ScriptCalculation.timeUsed - (minutes*60));
        var seconds = second.ToString();
        if(seconds.Length == 1){seconds = "0" + seconds;}
        seconds = seconds + "s";
        TimeText.text = minute + ":"+seconds;
        ScoresText.text = scores.ToString();
    }
}

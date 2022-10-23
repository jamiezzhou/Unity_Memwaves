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
    private string time = "1:20";
    private int scores = 1000;
    // Score thresholds
    private int twoStar = 500;
    private int oneStar = 200;

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
        SceneManager.LoadScene("16Pieces");
    }

    void initiateBackground(){
        if(scores >= twoStar){
            Background.sprite = GOOD;
        }
        else if (scores >= oneStar){
            Background.sprite = GREAT;
        } 
        else {
            Background.sprite = EXCELLENT;
        }
    }

    void SetText()
    {
        TimeText.text = time;
        ScoresText.text = scores.ToString();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScriptCalculation : MonoBehaviour
{
    // Start is called before the first frame update
    int BASE = 1000;
    int LOWER_BOUND = 100;
    int P12_THREE = 45;
    int P9_THREE = 30;
    int SECOND_DIFF =35;

    private float startTime;
    public static int count;
    public static float timeUsed;
    public static int score;
    public bool flagRecorded = false;

    void Start()
    {
        Debug.Log(Connect.pNum);
        Debug.Log(Connect.pieceNum);
        SetPuzzlePhoto(Connect.pNum, Connect.pieceNum);
        startTime = 0;
        // count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(count == Connect.pieceNum && !flagRecorded){
            // score = 
            timeUsed = (Time.time - startTime);
            Debug.Log(timeUsed);
            flagRecorded = true;
            calculateScore();
            Debug.Log(score);

            Debug.Log("Finished Game");
            StartCoroutine(WaitNextMenu(2f));
        }
    }

    IEnumerator WaitNextMenu(float t)
    {
        yield return new WaitForSeconds(t);
        SceneManager.LoadScene("FinishGame");
    }

    void SetPuzzlePhoto(int pNum, int pieceNum){
        // GameObject[] Pieces_;
        Image photo = GameObject.Find("Picture" + pNum).GetComponent<Image>();
        Debug.Log("Picture" + pNum);
        for (int i = 0; i < pieceNum; ++i){
           GameObject.Find("puzzle_" + i).transform.Find("puzzle").GetComponent<SpriteRenderer>().sprite = photo.sprite;

        }
    }

    void calculateScore(){
        score = BASE;
        if (Connect.pieceNum == 12){
            int temp = Convert.ToInt32(timeUsed - P12_THREE);
            if(temp > 0){
                while(score > LOWER_BOUND && temp >0){
                    score -= SECOND_DIFF;
                    temp --;
                }
                return;
            }
            else{
                while(temp < 0){
                    score += SECOND_DIFF;
                    temp ++;
                }
                return;
            }
        }

        if (Connect.pieceNum == 9){
            int temp = Convert.ToInt32(timeUsed - P9_THREE);
            if(temp > 0){
                while(score > LOWER_BOUND && temp > 0){
                    score -= SECOND_DIFF;
                    temp --;
                }
                return;
            }
            else{
                while(temp < 0){
                    score += SECOND_DIFF;
                    temp ++;
                }
                return;
            }
        }
    }
}

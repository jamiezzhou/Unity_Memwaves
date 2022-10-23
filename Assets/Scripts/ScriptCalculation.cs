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

    private float startTime;
    public static int count;
    public float timeUsed;
    public float scoreCal;
    void Start()
    {
        //Debug.Log(Connect.pNum, Connect.pieceNum);
        SetPuzzlePhoto(Connect.pNum, Connect.pieceNum);
        startTime = 0;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 12){
            // score = 
            timeUsed = (Time.time - startTime);

            Debug.Log("Finished Game");
            StartCoroutine(WaitNextMenu(2f));
        }
    }

    public IEnumerator WaitNextMenu(float t)
    {
        yield return new WaitForSeconds(t);
        SceneManager.LoadScene("FinishGame");
    }

    public void SetPuzzlePhoto(int pNum, int pieceNum){
        // GameObject[] Pieces_;
        Image photo = GameObject.Find("Picture" + pNum).GetComponent<Image>();
        for (int i = 0; i < pieceNum; ++i){
           GameObject.Find("puzzle_" + i).transform.Find("puzzle").GetComponent<SpriteRenderer>().sprite = photo.sprite;

        }
    }
}

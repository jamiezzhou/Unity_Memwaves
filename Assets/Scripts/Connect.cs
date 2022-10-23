using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Connect : MonoBehaviour
{   
    public static int pieceNum;
    public static int pNum;

    public Button Easy;
    public Button Hard;
    public GameObject picture1;
    public GameObject picture2;

    private bool level1Clicked = false;
    private bool level2Clicked = false;
    private bool pictureClicked = false;

    public void Start()
    {
        Easy.gameObject.SetActive(true);//can see button easy
        Hard.gameObject.SetActive(true);//can see button hard
        picture1.SetActive(false);//cannot see button picture1
        picture2.SetActive(false);//cannot see button picture2

    }

    // Load pictures accordingly
    public void LoadGame(GameObject button)
    {
        Debug.Log(button.name);
        pNum = Int32.Parse(button.name.Substring(7));
        Debug.Log(pNum);
        if(level1Clicked){
            SceneManager.LoadScene("9Pieces");
        }

        if(level2Clicked){
            SceneManager.LoadScene("16Pieces");
        }

    }

    public void Level1()
    {
        level1Clicked = true;
        Easy.interactable = false;
        pieceNum = 9;
        picture1.SetActive(level1Clicked);//picture1 is activated if the level is clicked
        picture2.SetActive(level1Clicked);//picture2 is activated if the level is clicked

        if(level2Clicked){
            level2Clicked = false;
            Hard.interactable = true;
            // Easy.colors.normalColor = Color.gray;
        }

    }

    public void Level2()
    {
        level2Clicked = true;
        Hard.interactable = false;
        pieceNum = 16;
        picture1.SetActive(level2Clicked);//picture1 is activated if the level is clicked
        picture2.SetActive(level2Clicked);//picture2 is activated if the level is clicked

        if(level1Clicked){
            level1Clicked = false;
            Easy.interactable = true;
            // Hard.colors.normalColor = Color.gray;
        }

    }

}


















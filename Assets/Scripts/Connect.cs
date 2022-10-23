using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Connect : MonoBehaviour
{   
    public static int level;
    public static int photo;

    public Button Easy;
    public Button Hard;
    public GameObject picture1;
    public GameObject picture2;

    private bool level1Clicked = false;
    private bool level2Clicked = false;
    private bool pictureClicked = false;

    void Awake(){
        DontDestroyOnLoad(photo);
    }

    public void Start()
    {
        Easy.gameObject.SetActive(true);//can see button easy
        Hard.gameObject.SetActive(true);//can see button hard
        picture1.SetActive(false);//cannot see button picture1
        picture2.SetActive(false);//cannot see button picture2

    }

    // Load pictures accordingly
    public void LoadGame()
    {
        photo = Int32.Parse(this.name.Substring(7));
        Debug.Log(photo);
        if(level1Clicked){
            SceneManager.LoadScene("9Pieces");
        }

        if(level2Clicked){
            SceneManager.LoadScene("16Pieces");
        }

        // if ((level1Clicked || level2Clicked) && !pictureClicked)
        // {
        //     Picture();
        // }
        // else
        // {
        //     DisplayFunctions();
        // }
        // if ((level1Clicked || level2Clicked) && pictureClicked)
        // {
        // }

    }

    // public void Load2Game()
    // {
    //     photo = picture2.GetComponent<Image>();
    //     if(level1Clicked){
    //         SceneManager.LoadScene("9Pieces");
    //     }

    //     if(level2Clicked){
    //         SceneManager.LoadScene("16Pieces");
    //     }
    // }

    public void Level1()
    {
        level1Clicked = true;
        Easy.interactable = false;
        level = 9;
        picture1.SetActive(level1Clicked);//picture1 is activated if the level is clicked
        picture2.SetActive(level1Clicked);//picture2 is activated if the level is clicked

        if(level2Clicked){
            level2Clicked = false;
            Hard.interactable = true;
            // Easy.colors.normalColor = Color.gray;
        }

        // if (!level1Clicked && !level2Clicked)
        // {
        //     level1Clicked = true; //user select level
        //     level = 9;
        // }
        // else if(level1Clicked)
        // {
        //     level1Clicked = false;//if the level is already selected, unselect
        //     level = 0;
        // }
        // picture1.SetActive(level1Clicked);//picture1 is activated if the level is clicked
        // picture2.SetActive(level1Clicked);//picture2 is activated if the level is clicked 
    }

    public void Level2()
    {
        level2Clicked = true;
        Hard.interactable = false;
        level = 16;
        picture1.SetActive(level2Clicked);//picture1 is activated if the level is clicked
        picture2.SetActive(level2Clicked);//picture2 is activated if the level is clicked

        if(level1Clicked){
            level1Clicked = false;
            Easy.interactable = true;
            // Hard.colors.normalColor = Color.gray;
        }

        // if (!level1Clicked && !level2Clicked)
        // {
        //     level2Clicked = true; //user select level
        //     level = 12;
        // }
        // else if(level2Clicked)
        // {
        //     level2Clicked = false;//if the level is already selected, unselect
        //     level = 0;
        // }
        // picture1.SetActive(level2Clicked);//picture1 is activated if the level is clicked
        // picture2.SetActive(level2Clicked);//picture2 is activated if the level is clicked 
    }

    // public void Picture()
    // {
    //     if (!pictureClicked)
    //     {
    //         pictureClicked = true; //user select picture 
    //     }
    //     else
    //     {
    //         pictureClicked = false;
            
    //     }

    // }
}


















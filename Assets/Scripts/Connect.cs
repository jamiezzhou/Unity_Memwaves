using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Connect : MonoBehaviour
{   
    public int level;

    public GameObject Easy;
    public GameObject Hard;
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

    // public void DisplayFunctions()
    // {
    //     Level();
    // }




    public void LoadGame(string input)
    {


        if ((level1Clicked || level2Clicked) && !pictureClicked)
        {
            Picture();
        }
        // else
        // {
        //     DisplayFunctions();
        // }
        if ((level1Clicked || level2Clicked) && pictureClicked)
        {
            SceneManager.LoadScene("16Pieces");
        }

    }

    public void Level1()
    {
        if (!level1Clicked && !level2Clicked)
        {
            level1Clicked = true; //user select level
            level = 9;
        }
        else if(level1Clicked)
        {
            level1Clicked = false;//if the level is already selected, unselect
            level = 0;
        }
        picture1.SetActive(level1Clicked);//picture1 is activated if the level is clicked
        picture2.SetActive(level1Clicked);//picture2 is activated if the level is clicked 
    }

    public void Level2()
    {
        if (!level1Clicked && !level2Clicked)
        {
            level2Clicked = true; //user select level
            level = 12;
        }
        else if(level2Clicked)
        {
            level2Clicked = false;//if the level is already selected, unselect
            level = 0;
        }
        picture1.SetActive(level2Clicked);//picture1 is activated if the level is clicked
        picture2.SetActive(level2Clicked);//picture2 is activated if the level is clicked 
    }

    public void Picture()
    {
        if (!pictureClicked)
        {
            pictureClicked = true; //user select picture 
        }
        else
        {
            pictureClicked = false;
            
        }

    }
}


















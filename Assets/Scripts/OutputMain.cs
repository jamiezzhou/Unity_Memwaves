using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class OutputMain : MonoBehaviour
{
    public InputField inputFieldChat;

    //void CreateText()
    //{
    //    //path of the file
    //    string path = Application.dataPath + "/Log.txt";
    //    //create File if it doesn't exist
    //    if (!File.Exists(path))
    //    {
    //        File.WriteAllText(path, "Login log \n\n");
    //    }
    //    //content of the file
    //    string content = "Login date: " + System.DateTime.Now + "\n";
    //    //Add some text to it
    //    File.AppendAllText(path, content); 
    //}

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning(Application.streamingAssetsPath);

        Directory.CreateDirectory(Application.streamingAssetsPath + "/Score_Logs/");
        CreateTextFile();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateTextFile()
    {
        string fileName = Application.streamingAssetsPath + "/Score_Logs/" + "ScoreLevel1" + ".txt";

        if (!File.Exists(fileName))
        {
            File.WriteAllText(fileName, "Score Level 1 LOG" + "\n");
        }
    }
}

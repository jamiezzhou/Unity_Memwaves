using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class OutputMain : MonoBehaviour
{
    // public InputField inputFieldChat;
    string fileName;
    int score_log;
    void Start()
    {
        Debug.LogWarning(Application.streamingAssetsPath);
        Directory.CreateDirectory(Application.streamingAssetsPath + "/Score_Logs/");

        CreateTextFile();
        ReadFile();
        WriteFile();

    }

    void WriteFile()
    {
        score_log += ScriptCalculation.score;
        using(StreamWriter writer = new StreamWriter(fileName)){
            writer.WriteLine(score_log.ToString());
        }
    }

    void ReadFile()
    {
        string input;
        using(StreamReader reader = new StreamReader(fileName)){
            input = reader.ReadLine();
        }
        try{
            score_log = Convert.ToInt32(input);
        }
        catch{
            Debug.Log("Score not properly logged");
        }

    }

    void CreateTextFile()
    {
        fileName = Application.streamingAssetsPath + "/Score_Logs/" + "PlayerScore" + ".txt";

        if (!File.Exists(fileName))
        {
            File.WriteAllText(fileName, "0");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptCalculation : MonoBehaviour
{
    // Start is called before the first frame update
    // private float

    private float startTime;
    public static int count;
    public float timeUsed;
    public float scoreCal;
    void Start()
    {
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
}

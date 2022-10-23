using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiecesScript : MonoBehaviour
{
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;
    public bool updateFlag;
    // Start is called before the first frame update
    void Start()
    {
        ScriptCalculation.count = 0;
        updateFlag = false;
        RightPosition = transform.position;
        transform.position = new Vector2(Random.Range(-1.7f,1.7f), Random.Range(-4.3f, -2.3f));
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, RightPosition) < 0.35f){
           if(!Selected){
            transform.position = RightPosition;
            InRightPosition = true;
            Debug.Log("In right Postion");
            if(!updateFlag){
                Debug.Log("Count++");
                updateFlag = true;
                ScriptCalculation.count ++;
            }
           }
        }
    }
}

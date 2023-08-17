using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    int limitTime = 30000;
    int limitTime_sub;
    public static int timeBreak = 0;
    public Text ScriptTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        limitTime --;
        limitTime_sub = limitTime / 1000;
        if(limitTime_sub == 0)
        {
            timeBreak = 1;
            limitTime++;
        }


        ScriptTime.text = limitTime_sub.ToString();
    }
}

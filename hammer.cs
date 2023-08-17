using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammer : MonoBehaviour
{
    public static int counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("ddg"))
        {
            counter = counter + 1;
            Debug.Log("HIT 01");
            if (time.timeBreak == 1)
            {
                counter--;
            }
        }
    }
}

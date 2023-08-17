using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ddg : MonoBehaviour
{
    public float xPos, yPos, zPos;
    public float yPlus;
    public int random_p;
    double speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        xPos = 0.0f;
        yPos = 0.0f;
        zPos = 36.0f;
        yPlus = 0.04f;
    }

    // Update is called once per frame
    void Update()
    {
        speed++;
        if(speed % 120 == 0 && yPos < -14)
        {
            random_p = Random.Range(0, 6);
        }

        if (yPos > 7 || yPos < -16)
        {
            yPlus = yPlus * -1;
        }
        yPos = yPos + yPlus;

        if(random_p == 0)
        {
            xPos = -36.0f;
            zPos = 14.0f;
        }
        else if (random_p == 1)
        {
            xPos = 0.0f;
            zPos = 36.0f;
        }
        else if (random_p == 2)
        {
            xPos = 36.0f;
            zPos = 14.0f;
        }
        else if (random_p == 3)
        {
            xPos = 0.0f;
            zPos = -6.0f;
        }
        else if (random_p == 4)
        {
            xPos = -36.0f;
            zPos = -27.0f;
        }
        else
        {
            xPos = 36.0f;
            zPos = -27.0f;
        }

        transform.position = new Vector3(xPos, yPos, zPos);
    }
}

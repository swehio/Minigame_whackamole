using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerAll : MonoBehaviour
{
    public int rotX, rotP;
    bool hammering = false;
    // Start is called before the first frame update
    void Start()
    {
        rotX = -90;
        rotP = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            hammering = true;
        }
        if(hammering == true)
        {
            if(Input.mousePosition.x < Screen.width/3 && Input.mousePosition.y > Screen.height/2)
            {
                transform.position = new Vector3(-35, 20, -20);
            }
            if (Input.mousePosition.x < Screen.width/3 && Input.mousePosition.y < Screen.height/2)
            {
                transform.position = new Vector3(-35, 20, -60);
            }
            if(Input.mousePosition.x > Screen.width/3 && Input.mousePosition.x < Screen.width * 2 / 3 && Input.mousePosition.y > Screen.height/2)
            {
                transform.position = new Vector3(0, 20, 0);
            }
            if (Input.mousePosition.x > Screen.width/3 && Input.mousePosition.x < Screen.width * 2 / 3 && Input.mousePosition.y < Screen.height/2)
            {
                transform.position = new Vector3(0, 20, -40);
            }
            if (Input.mousePosition.x > Screen.width*2/3 && Input.mousePosition.x < Screen.width && Input.mousePosition.y > Screen.height / 2)
            {
                transform.position = new Vector3(37, 20, -20);
            }
            if (Input.mousePosition.x > Screen.width*2/3 && Input.mousePosition.x < Screen.width && Input.mousePosition.y < Screen.height / 2)
            {
                transform.position = new Vector3(37, 20, -60);
            }

            if (rotX > 0)
            {
                rotP = rotP * -1;
            }
            rotX = rotX + rotP;
            transform.rotation = Quaternion.Euler(rotX, 0, 0);
            if(rotX < -90)
            {
                hammering = false;
                rotX = -90;
                rotP = rotP * -1;
                transform.position = new Vector3(85, 15, 62);
            }
        }
    }
}

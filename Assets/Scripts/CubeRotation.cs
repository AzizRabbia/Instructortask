using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{

    public float sec = 0f;
    public int minutes = 0;
    private float Rotation = 20f;
    private float Scaling = 1f;
    public bool isGame;
    private int state = 0;
 
    //giving access to all arrow keys if bool is true and  rotating cube in all axis

    void UpAndDownRotation()

    {
        if (isGame == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Rotate(new Vector3(0f, Rotation * Time.deltaTime, 0f));
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Rotate(new Vector3(0f, -Rotation * Time.deltaTime, 0f));
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(new Vector3(Rotation * Time.deltaTime, 0f, 0f));
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(new Vector3(-Rotation * Time.deltaTime, 0f, 0f));
            }
        }


    }
    //scaling the size of cube
    void SizeOfCube()
    {
        if (isGame == true) 
        {
        
            if (Input.GetKey(KeyCode.Space))
            {
                transform.localScale += new Vector3(Scaling * Time.deltaTime, Scaling * Time.deltaTime, Scaling * Time.deltaTime);
                state = 1;
            }
            else
            {
                if (state == 1 && transform.localScale.x > 1f)
                {
                    transform.localScale -= new Vector3(Scaling * Time.deltaTime, Scaling * Time.deltaTime, Scaling * Time.deltaTime);
                    
                }
                
            }
        }
    }


    void Clock()
    {
        sec = sec  + 1 * Time.deltaTime ;
        if(sec > 59f)
        {
            minutes++;
            sec = 0f;
        }

        print("Minutes : " + minutes + "Seconds : " + sec);
    } 


        // Update is called once per frame
    void Update()
    {
        
        UpAndDownRotation();
        SizeOfCube();
        Clock();
    }
    
}

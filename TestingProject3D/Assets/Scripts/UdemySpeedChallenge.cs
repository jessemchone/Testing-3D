using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UdemySpeedChallenge : MonoBehaviour
{
    [SerializeField] float amount = 5f;
    [SerializeField] private float speed;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            speed += amount;
        
            if (speed >= 20)
            {
                Debug.Log("You need to slow down! Your speed is " + speed);
            }
            else
            {
                Debug.Log("You need to speed up! Your speed is " + speed);
            }     
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            speed -= amount;
        
            if (speed < 0)
            {
                speed = 0f;
            }
            
            if (speed >= 20)
            {
                Debug.Log("You need to slow down! Your speed is " + speed);
            }
            else
            {
                Debug.Log("You need to speed up! Your speed is " + speed);
            }
        }   
    }
}

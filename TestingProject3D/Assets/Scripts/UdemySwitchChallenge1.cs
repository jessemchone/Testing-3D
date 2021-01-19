using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UdemySwitchChallenge1 : MonoBehaviour
{
    private int _points;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _points = 100;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            _points = 50;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            _points = 0;
        }

        switch (_points)
        {
            case 100:
                Debug.Log("You have 100 points!");
                break;
            
            case 50:
                Debug.Log("You have 50 points!");
                break;
            
            default:
                Debug.Log("You need 50 or 100 points to receive a message! Try again.");
                break;
        }
    }
}

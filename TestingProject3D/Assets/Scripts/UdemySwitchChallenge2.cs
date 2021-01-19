using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UdemySwitchChallenge2 : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    private int _colorID;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _colorID = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _colorID = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _colorID = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _colorID = 4;
        }

        ChangeCubeColor(_cube, _colorID);
    }

    private void ChangeCubeColor(GameObject cube, int colorID)
    {
        switch (colorID)
        {
            case 1:
                cube.GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            
            case 2:
                cube.GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            
            case 3:
                cube.GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;
            
            case 4:
                cube.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            
            default:
                cube.GetComponent<MeshRenderer>().material.color = Color.black;
                break;
        }
    }
}

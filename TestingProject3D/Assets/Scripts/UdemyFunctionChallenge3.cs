using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UdemyFunctionChallenge3 : MonoBehaviour
{
    [SerializeField] Vector3[] positions;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = SetPosition(GenerateRandomNumber());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = SetPosition(GenerateRandomNumber());
        }
    }

    private int GenerateRandomNumber()
    {
        int randomNumber = Random.Range(0, 4);

        return randomNumber;
    }

    private Vector3 SetPosition(int index)
    {       
        Vector3 newPos = positions[index];

        return newPos;
    }

    // This didn't work, remember why
    /*private void SetPosition(int index)
    {
        transform.position = positions[index];
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UdemyArrayChallenge : MonoBehaviour
{
    [SerializeField] GameObject[] cubes;
    
    //private string[] _names = new string[5];
    [SerializeField] string[] _names2;
    //private int[] _ages = new int[5];
    [SerializeField] int[] _ages2;
    //private string[] _cars = new string[5];
    [SerializeField] string[] _cars2;
    //private int[] _albums = new int[] { 1, 2, 3, 4, 5 };
    
    // Start is called before the first frame update
    void Start()
    {
        /*_names[0] = "James";
        _names[1] = "Lars";
        _names[2] = "Kirk";
        _names[3] = "Jason";
        _names[4] = "Cliff";

        _ages[0] = 25;
        _ages[1] = 33;
        _ages[2] = 22;
        _ages[3] = 21;
        _ages[4] = 27;*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //int randomIndex = Random.Range(0, 4);
            //Debug.Log(_names2[randomIndex] + " is " + _ages2[randomIndex] + ". His favorite car is " + _cars2[randomIndex]);
        
            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[i].GetComponent<MeshRenderer>().material.color = Color.blue;
            }
        }
    }
}

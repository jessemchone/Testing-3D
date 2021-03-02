using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UdemyEventChallenge : MonoBehaviour
{
    public delegate void ButtonDown();
    public static event ButtonDown OnButtonDown;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            ButtonClick();
        }*/
    }

    public void ButtonClick()
    {
        if (OnButtonDown != null)
        {
            OnButtonDown();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private Player player;

    private int exp;
    
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Player").GetComponent<Player>();
        player = FindObjectOfType<Player>();
        exp = player.PlayerEXP;
        Debug.Log("Test exp is " + exp);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            exp = player.PlayerEXP;
            Debug.Log("Test exp is " + exp);
            //GetComponent<MeshRenderer>().enabled = false;
        }
    }
}

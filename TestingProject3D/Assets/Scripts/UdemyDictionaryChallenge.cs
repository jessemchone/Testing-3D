using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UdemyDictionaryChallenge : MonoBehaviour
{
    private Dictionary<int, string> _itemDB = new Dictionary<int, string>();
    
    // Start is called before the first frame update
    void Start()
    {
        _itemDB.Add(0, "James");
        _itemDB.Add(1, "Kirk");
        _itemDB.Add(2, "Lars");
        _itemDB.Add(3, "Jason");
        _itemDB.Add(4, "Cliff");
        _itemDB.Add(5, "Rob");

        UdemyEventChallenge.OnButtonDown += ChangeCubeColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (KeyValuePair<int, string> name in _itemDB)
            {
                Debug.Log("ID is: " + name.Key + " Name is: " + name.Value);
            }
        }
    }

    private void OnDisable()
    {
        UdemyEventChallenge.OnButtonDown -= ChangeCubeColor;
    }

    public void ChangeCubeColor()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UdemyListChallenge1 : MonoBehaviour
{
    [SerializeField] private List<string> _names;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (string name in _names)
        {
            Debug.Log(name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_names.Count > 0)
            {
                _names.Remove(_names[Random.Range(0, _names.Count)]);
                //_names.RemoveAt(Random.Range(0, _names.Count));
            }
            else
            {
                Debug.Log("There are no names in the list!");
            }

            foreach (string name in _names)
            {
                Debug.Log(name);
            }

            Debug.Log(_names.Count);
        }
    }
}

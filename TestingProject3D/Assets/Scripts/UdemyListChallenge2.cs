using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UdemyListChallenge2 : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjectPrefabs;

    [SerializeField] List<GameObject> spawnedObjects = new List<GameObject>();

    [SerializeField] int maxObjects = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnedObjects.Count < maxObjects)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                {
                    GameObject newObject = Instantiate(gameObjectPrefabs[Random.Range(0, gameObjectPrefabs.Length)], new Vector3(Random.Range(-10f, 11f), Random.Range(-10f, 11f), 0f), Quaternion.identity);
                    spawnedObjects.Add(newObject);
                }
            }
        }
       else
       {
            foreach (GameObject obj in spawnedObjects)
            {
                obj.GetComponent<MeshRenderer>().material.color = Color.green;
            }

            spawnedObjects.Clear();
       }
    }
}

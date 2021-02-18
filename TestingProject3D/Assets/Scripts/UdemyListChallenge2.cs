using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UdemyListChallenge2 : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjectPrefabs;

    [SerializeField] List<GameObject> spawnedObjects = new List<GameObject>();

    [SerializeField] int maxObjects = 10;

    private float objectsSpawned = 0;
    private bool InitColorChange;

    // Update is called once per frame
    void Update()
    {
        if (spawnedObjects.Count < maxObjects)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                {
                    GameObject newObject = Instantiate(gameObjectPrefabs[Random.Range(0, gameObjectPrefabs.Length)], new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0f), Quaternion.identity);
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

            //Invoke("Deactivate", 5f);
        }
    }

    public void Deactivate()
    {
        foreach (GameObject obj in spawnedObjects)
        {
            obj.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}

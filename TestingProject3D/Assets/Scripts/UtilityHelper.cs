using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityHelper
{ 
    public static void ChangeColor(GameObject obj, Color color, int randomInt)
    {
        randomInt = Random.Range(0, 4);
        
        switch (randomInt)
        {
            case 0:
                {
                    color = Color.red;
                    break;
                }

            case 1:
                {
                    color = Color.blue;
                    break;
                }

            case 2:
                {
                    color = Color.yellow;
                    break;
                }

            case 3:
                {
                    color = Color.green;
                    break;
                }
        }

        obj.GetComponent<MeshRenderer>().material.color = color;
    }
}

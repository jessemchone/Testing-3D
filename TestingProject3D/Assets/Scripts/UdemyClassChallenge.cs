using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UdemyClassChallenge : MonoBehaviour
{
    [SerializeField] UdemyCustomer _customer1;
    [SerializeField] UdemyCustomer _customer2;
    [SerializeField] UdemyCustomer _customer3;
    
    // Start is called before the first frame update
    void Start()
    {
        _customer1 = new UdemyCustomer();
        _customer2 = new UdemyCustomer("Hetfield", "James", 35, "Male", "Musician");

        _customer1.lastName = "Ulrich";
        _customer1.firstName = "Lars";
        _customer1.age = 32;
        _customer1.gender = "Male";
        _customer1.occupation = "Drummer";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(_customer3.firstName + " " + _customer3.lastName);
        }
    }
}

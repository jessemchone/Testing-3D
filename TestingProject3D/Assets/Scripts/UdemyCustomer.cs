using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UdemyCustomer
{
    public string lastName;
    public string firstName;
    public int age;
    public string gender;
    public string occupation;

    public UdemyCustomer()
    {

    }

    public UdemyCustomer(string lastName, string firstName, int age, string gender, string occupation)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;
    }
}

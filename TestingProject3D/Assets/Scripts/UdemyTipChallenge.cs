using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UdemyTipChallenge : MonoBehaviour
{
    [SerializeField] float bill;
    [SerializeField] float tipPercentage;

    private float totalWithTip;
    
    // Start is called before the first frame update
    void Start()
    {
        //tipPercentage /= 100f;
        //totalWithTip = bill + (tipPercentage * bill);
        totalWithTip = CalculateTotal(bill, tipPercentage);

        Debug.Log("Your total with tip is " + totalWithTip + " dollars");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private float CalculateTotal(float billAmount, float tipPercentage)
    {
        tipPercentage /= 100f;

        float total = billAmount + (tipPercentage * billAmount);

        total = Mathf.Round(total * 100) / 100;

        return total;
    }
}

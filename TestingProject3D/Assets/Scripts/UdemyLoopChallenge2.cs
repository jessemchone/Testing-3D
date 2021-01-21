using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UdemyLoopChallenge2 : MonoBehaviour
{
    private float _speed;
    private float _maxSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        _maxSpeed = Random.Range(60, 120);
        Debug.Log("Max speed is " + _maxSpeed);
        StartCoroutine(IncrementSpeedRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
        // While loop
        /*while (_speed <= _maxSpeed)
        {
            _speed += 5f;
        }

        Debug.Log("Speed is " + _speed);*/
    }

    private IEnumerator IncrementSpeedRoutine()
    {
        // Remember that the yield should go inside the loop
        while (true)
        {
            _speed += 1f;
            Debug.Log("Speed is " + _speed);

            yield return new WaitForSeconds(0.5f);

            if (_speed >= _maxSpeed) break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UdemyFunctionChallenge : MonoBehaviour
{
    //[SerializeField] GameObject cube;

    //Color color = Color.green;

    [SerializeField] int _playerHealth;
    [SerializeField] int _damageAmount;

    private bool _isDead;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_isDead)
        {
            _damageAmount = Random.Range(10, 40);
            DamagePlayer(_damageAmount);
            //ChangeColor(cube, color);
        }
    }

    private void DamagePlayer(int amount)
    {
        _playerHealth -= amount;

        if (_playerHealth <= 0)
        {
            _playerHealth = 0;
            _isDead = true;
            Debug.Log("The player has died a painful death");
        }
    }
    
    private void ChangeColor(GameObject obj, Color color)
    {
        obj.GetComponent<MeshRenderer>().material.color = color;
    }
}

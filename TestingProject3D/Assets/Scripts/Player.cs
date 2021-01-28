using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Spell[] _spells;

    public int playerEXP;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CastRandomSpell();
            Debug.Log("Your experience is now " + playerEXP + ".");
        }
    }

    private void CastRandomSpell()
    {
        int randomIndex = Random.Range(0, _spells.Length);
        _spells[randomIndex].CastSpell();
        playerEXP += _spells[randomIndex].expGained;
    }
}

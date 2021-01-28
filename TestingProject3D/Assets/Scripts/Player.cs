using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Spell[] _spells;

    [SerializeField] string[] _names = new string[] { "Poison", "Fire", "Water", "Ice"};

    [SerializeField] private int currentPlayerLevel;
    
    private int playerEXP;

    public static Player instance;

    public int PlayerEXP
    {
        get
        {
            return playerEXP;
        }
        private set
        {
            playerEXP = value;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {   
        /*for (int i = 0; i < _names.Length; i++)
        {
            Debug.Log(_names[i]);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //CastRandomSpell();
            CastAvailableSpell();
            //Debug.Log("Your experience is now " + playerEXP + ".");
        }
    }

    private void CastRandomSpell()
    {
        int randomIndex = Random.Range(0, _spells.Length);
        
        if (_spells[randomIndex].requiredLevel == currentPlayerLevel)
        {
            _spells[randomIndex].CastSpell();
            playerEXP += _spells[randomIndex].expGained;
            Debug.Log("Your experience is now " + playerEXP + ".");
        }
        else
        {
            Debug.Log("Your level is not high enough to cast the " + _spells[randomIndex].name + " spell!");
        }
    }

    private void CastAvailableSpell()
    {
        foreach (Spell spell in _spells)
        {
            if (spell.requiredLevel == currentPlayerLevel)
            {
                spell.CastSpell();
                //return;
            }
        }
    }
}

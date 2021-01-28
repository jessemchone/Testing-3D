using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Spell
{
    public string name;
    public int spellID;
    public int expGained;


    public Spell(string name, int ID, int expGained)
    {
        this.name = name;
        this.spellID = ID;
        this.expGained = expGained;
    }

    public void CastSpell()
    {
        Debug.Log("You have cast a " + this.name + " spell. You have gained " + this.expGained + " experience.");
    }
}

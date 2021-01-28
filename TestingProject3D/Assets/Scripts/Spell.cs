using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Spell
{
    public string name;
    public int spellID;
    public int expGained;
    public int requiredLevel;

    public Spell(string name, int ID, int reqLevel, int expGained)
    {
        this.name = name;
        this.spellID = ID;
        this.requiredLevel = reqLevel;
        this.expGained = expGained;
    }

    public void CastSpell()
    {
        Debug.Log("You have cast a " + this.name + " spell. You have gained " + this.expGained + " experience.");
    }
}

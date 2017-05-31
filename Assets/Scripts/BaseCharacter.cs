using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter {
    // Variables \\
    /*
     * This class will be used as the base for all the player characters and non-player caracters
     * 
     * Variables that need to be included:
     *  Info:
     *    Name      // The characters name 
     *    Level     // lvl for short
     *  
     *  // These variables will need two variables one for minimum and maximum
     *    Health    // HP for short
     *    Stamina   // SP for short
     *    Energy    // EP for short
     *    
     *   Stats:
     *    Strength      // 
     *    Dexterity     // 
     *    Inteligence   // 
     *    Wisdom        // 
     *    Constitution  // 
     *    Charisma      // 
     *    
     * 
     * */

    // Info
    string name;
    int lvl;

    int minHP;
    int maxHP;
    int minSP;
    int maxSP;
    int minEP;
    int maxEP;

    //Stats
    int str;
    int dex;
    int intl;
    int wis;
    int con;
    int cha;

    // Getters and Setters \\
    // Info
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Lvl
    {
        get { return lvl; }
        set { lvl = value; }
    }

    public int MinHP
    {
        get { return minHP; }
        set { minHP = value; }
    }

    public int MaxHP
    {
        get { return maxHP; }
        set { maxHP = value; }
    }

    public int MinSP
    {
        get{ return minSP; }
        set { minSP = value; }
    }

    public int MaxSP
    {
        get { return maxSP; }
        set { maxSP = value; }
    }

    public int MinEP
    {
        get { return minEP; }
        set { minEP = value; }
    }

    public int MaxEP
    {
        get { return maxEP; }

        set { maxEP = value; }
    }

    //Stats
    public int Str
    {
        get { return str; }
        set { str = value; }
    }

    public int Dex
    {
        get { return dex; }
        set { dex = value; }
    }

    public int Intl
    {
        get { return intl; }
        set { intl = value; }
    }

    public int Wis
    {
        get { return wis; }

        set { wis = value; }
    }

    public int Con
    {
        get { return con; }
        set { con = value; }
    }

    public int Cha
    {
        get { return cha; }
        set { cha = value; }
    }
}

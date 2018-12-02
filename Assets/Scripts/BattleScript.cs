using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

interface IAttacker {
    void TakeDamage (double damage);
}

public class Ship
{
    public int Level;
    public double Health;
    public Ship(int level)
    {
        this.Level = level;
    }
}

public class Mobile
{
    
    public int Level;
    public double Health;
    public double startingHealth;
    
    public Mobile (int level)
    {
        this.Level = level;
    }
}

class Enemy : Mobile, IAttacker 
{
    public string Name;
    private double Weapon;
    public double Damage;

    public Enemy(string name, int level) : base(level)
    {
        this.Name = name;
        this.Health = level * 10.0;
        this.startingHealth = level * 10.0;
        this.Weapon = 3.0;
        this.Damage = level * this.Weapon;
    }

    override public string ToString()
    {
        return this.Name;
    }

    public void TakeDamage(double damage)
    {
        this.Health -= damage;
    }
}

class Player : Mobile, IAttacker
{
    private double Weapon;
    public double Damage;
    public Player(int level) : base(level)
    {
        this.Health = level * 10.0;
        this.startingHealth = level * 10.0;
        this.Weapon = 5.0;
        this.Damage = level * Weapon;
    }

    public void TakeDamage(double damage)
    {
        this.Health -= damage;
    }
}

class BattleScript : MonoBehaviour
{
    [HideInInspector]
    public bool battleStart = false;

    public Text levelText;


    public void Start ()
    {
        levelText.text = "A horde of natives leaps out and attacks you!";
        Debug.Log("A horde of natives leaps out and attacks you!");

        Enemy natives = new Enemy("natives", 1);
        Player player = new Player(2);
        

        if (Input.GetKey("space"))
        {
            levelText.text = "";
            battleStart = true;
        }

        if (battleStart)
        {
            while (natives.Health > 0 && player.Health > 0)
            {
                natives.TakeDamage(player.Damage);
                player.TakeDamage(natives.Damage);
            }
        }
        if (natives.Health > 0)
        {
            levelText.text = "Your ship was lost...";
            Debug.Log("Your ship was lost...");
            battleStart = false;
            natives.Health = natives.startingHealth;
        } else
        {
            levelText.text = "Hurrah! You beat the natives!";
            Debug.Log("Hurrah! You beat the natives!");
            battleStart = false;
            natives.Health = natives.startingHealth;
        }
        
    }
}

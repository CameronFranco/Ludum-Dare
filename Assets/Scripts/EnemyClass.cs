/*using System;
using System.Collections;

public class Mobile
{
    
    public int Level;
    public double Health;
    public double startingHealth;
    
    public void Ship(int level)
    {
        this.Level = level;
    }
}

class Enemy : Mobile, IAttacker 
{
    public string Name;
    private double Weapon;
    public double Damage;

    public void Natives(string name, int level)
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
}*/
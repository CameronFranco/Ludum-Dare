/* using System;
using System.Collections;

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
}*/
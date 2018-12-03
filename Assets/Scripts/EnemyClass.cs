using System;
using System.Collections;


namespace GameBattleScripts
{

    public class Mobile
    {
        
        public int Level;
        public double Health;
        public double startingHealth;
        
        public Mobile(int level)
        {
            this.Level = level;
        }
    }

    class Enemy : Mobile, IAttacker 
    {
        public string Name;
        private double Weapon;
        public double Damage;
        private int enemyMod;
        private static Random rnd = new Random ();

        public Enemy(string name, int level) : base(level)
        {

            enemyMod = rnd.Next(5, 10);

            this.Name = name;
            this.Health = level * enemyMod;
            this.startingHealth = level * enemyMod;
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
}
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
        private int WeaponMod;
        public double Damage;
        private int enemyMod;
        private static Random rnd = new Random ();

        public Enemy(string name, int level, int weaponMod) : base(level)
        {

            enemyMod = rnd.Next(5, 10);

            this.Name = name;
            this.Health = level * enemyMod;
            this.startingHealth = level * enemyMod;
            this.WeaponMod = weaponMod;
            this.Damage = level * this.WeaponMod;
        }

        public string Stats(){
            return "Enemy Stats:\n\tHealth: "+this.Health+"\n\tDamage: "+this.Damage+"\n\tmod: "+this.enemyMod;
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
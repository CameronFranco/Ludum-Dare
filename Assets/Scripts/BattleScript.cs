using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace  GameBattleScripts
{

    class BattleScript : MonoBehaviour
    {

        [HideInInspector]
        public bool battleStart = false;
        [HideInInspector]
        public bool battleEnd = false;

        public Text levelText;
        private string WinnerText = "";


        public void Start ()
        {
            levelText.text = "A horde of natives leaps out and attacks you!";
            Debug.Log("A horde of natives leaps out and attacks you!");

            Enemy natives = new Enemy("natives", 2);
            Player player = new Player(1);
            Debug.Log ("The enemy's health: " + natives.Health);

            while (natives.Health > 0 && player.Health > 0)
            {
                natives.TakeDamage(player.Damage);
                player.TakeDamage(natives.Damage);

            }

            if (natives.Health > 0)
            {
                WinnerText = "Your ship was lost...";
                natives.Health = natives.startingHealth;
            } 
            else if (player.Health > 0)
            {
                WinnerText = "Hurrah! You beat the natives!";
                natives.Health = natives.startingHealth;
            }
            
            
        }

        public void Update () 
        {
            if (Input.GetKeyDown("space"))
            {
                levelText.text = WinnerText;
                Debug.Log(WinnerText);
            }

        }
    }
}
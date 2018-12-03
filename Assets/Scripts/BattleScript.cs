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

        public string enemyName;
        public int enemyLevel;

        public Text levelText;
        private string WinnerText = "";


        public void Start ()
        {
            levelText.text = "A horde of "+ enemyName +" leaps out and attacks you!";
            Debug.Log("A horde of "+ enemyName +" leaps out and attacks you!");

            SimpleGameManager GM = SimpleGameManager.Instance;
            Enemy natives = new Enemy(enemyName, enemyLevel);
            Player player = GM.player;

            Debug.Log("The player's health: "+player.Health);
            Debug.Log ("The enemy: " + natives.Stats());

            while (natives.Health > 0 && player.Health > 0)
            {
                natives.TakeDamage(player.Damage);
                player.TakeDamage(natives.Damage);
                Debug.Log("The player's health: "+player.Health);
                Debug.Log ("The enemy's health: " + natives.Health);
            }

            if (natives.Health > 0)
            {
                WinnerText = "Your ship was lost...";
                natives.Health = natives.startingHealth;
            }
            else if (player.Health > 0)
            {
                WinnerText = "Hurrah! You beat the "+enemyName+"!";
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
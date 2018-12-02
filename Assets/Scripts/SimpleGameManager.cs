using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleGameManager : MonoBehaviour
{
    public GameObject Selected = null;
    bool Island1 = true;
    bool Island2 = true;
    bool Island3 = true;
    bool Island4 = true;
    bool Island5 = true;

    private static SimpleGameManager instance = null;
    public List<GameObject> Crew = new List<GameObject>();
    public static SimpleGameManager Instance
    {
        get
        {
            if (SimpleGameManager.instance == null)
            {
                SimpleGameManager.instance = FindObjectOfType<SimpleGameManager>();
                if (SimpleGameManager.instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "SimpleGameManager";
                    SimpleGameManager.instance = go.AddComponent<SimpleGameManager>();
                    DontDestroyOnLoad(go);
                }
            }
            return SimpleGameManager.instance;
        }
    }
    // Class Methods
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //can i got to this island
    public bool IsAlllowed (int island){
        if (island == 1){
            return Island1;
        }if (island == 2){
            return Island1;
        }if (island == 3){
            return Island1;
        }if (island == 4){
            return Island1;
        }if (island == 5){
            return Island1;
        }
         else {
            return false;
        }
    }
    public void visitIsland (int island)
    {
        Island1 = false;
        if (island == 2){
            Island4 = false;
            Island5 = false;
            Island2 = false;
        }
        if (island == 4){
            Island4 = false;
            Island3 = false;
            Island2 = false;
        }
        if (island == 3){
            Island4 = false;
            Island5 = false;
            Island2 = false;
            Island3 = false;
        }
        if (island == 5){
            Island4 = false;
            Island5 = false;
            Island2 = false;
            Island3 = false;
        }
    }
    public void AddCrew(GameObject crewmate)
    {
        DontDestroyOnLoad(crewmate);
        Crew.Add(crewmate);
    }
}


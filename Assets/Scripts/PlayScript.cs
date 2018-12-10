using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{

    public void SceneSwitcher()
    {
        SimpleGameManager GM = SimpleGameManager.Instance;
        GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/CrewMember"));
        GM.AddCrew(go);
        go = (GameObject)Instantiate(Resources.Load("Prefabs/CrewMember"));
        GM.AddCrew(go);
        go = (GameObject)Instantiate(Resources.Load("Prefabs/CrewMember"));
        GM.AddCrew(go);
        go = (GameObject)Instantiate(Resources.Load("Prefabs/CrewMember"));
        GM.AddCrew(go);
    
        SceneManager.LoadScene(1);
    }
}

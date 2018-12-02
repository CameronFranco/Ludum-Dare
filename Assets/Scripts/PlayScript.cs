using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{

    public void SceneSwitcher()
    {
        SimpleGameManager GM = SimpleGameManager.Instance;
        Debug.Log(GM.GetHashCode());
        GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/CrewMember"));
        Debug.Log(go);
        GM.AddCrew(go);
        Debug.Log(GM.Crew[0].name);
        go = (GameObject)Instantiate(Resources.Load("Prefabs/CrewMember"));
        GM.AddCrew(go);
        go = (GameObject)Instantiate(Resources.Load("Prefabs/CrewMember"));
        GM.AddCrew(go);
        go = (GameObject)Instantiate(Resources.Load("Prefabs/CrewMember"));
        GM.AddCrew(go);
        foreach (GameObject cm in GM.Crew)
        {
            Debug.Log(cm);
        }
        SceneManager.LoadScene(1);
    }
}

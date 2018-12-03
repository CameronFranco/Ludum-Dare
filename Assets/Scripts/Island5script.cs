using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Island5script : MonoBehaviour
{

    public void SceneSwitcher()
    {
        SimpleGameManager GM = SimpleGameManager.Instance;
        if (GM.IsAlllowed(5))
        {
            GM.visitIsland(5);
            SceneManager.LoadScene(6);
        }
    }
}

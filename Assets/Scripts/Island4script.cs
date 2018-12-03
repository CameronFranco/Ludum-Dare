using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Island4script : MonoBehaviour
{

    public void SceneSwitcher()
    {
        SimpleGameManager GM = SimpleGameManager.Instance;
        if (GM.IsAlllowed(4))
        {
            GM.visitIsland(4);
            SceneManager.LoadScene(5);
        }
    }
}

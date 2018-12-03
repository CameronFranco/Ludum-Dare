using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Island1script : MonoBehaviour
{

    public void SceneSwitcher()
    {
        SimpleGameManager GM = SimpleGameManager.Instance;
        GM.visitIsland (1);
        SoundManager.Instance.StopMusic();
        SceneManager.LoadScene(2);
    }
}

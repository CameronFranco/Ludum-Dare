﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class island2script : MonoBehaviour
{
    public void SceneSwitcher()
    {
        SimpleGameManager GM = SimpleGameManager.Instance;
        if (GM.IsAlllowed(3))
        {
            GM.visitIsland (2);
            SoundManager.Instance.StopMusic();
            SceneManager.LoadScene(3);
        }

    }
}

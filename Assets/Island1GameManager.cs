using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Island1GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SimpleGameManager GM = SimpleGameManager.Instance;
        Debug.Log(GM.GetHashCode());
        foreach(GameObject cm in GM.Crew)
        {
            Debug.Log(cm);
        }
    }
	
	
}

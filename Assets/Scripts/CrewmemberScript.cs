using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CrewmemberScript : MonoBehaviour, IPointerClickHandler {
    SimpleGameManager GM;

    // On Awake, set the variable to our SimpleGameManager.Instance
    // (Note the capital 'I')
    void Awake()
    {
        GM = SimpleGameManager.Instance;
    }
    //Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.

        GM.Selected = this.gameObject;
        Debug.Log(name + " Game Object Clicked!");
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

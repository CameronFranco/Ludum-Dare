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
        GM.Selected = this.gameObject;
        Debug.Log(name + " Game Object Clicked!");
        Material mat = gameObject.GetComponent<Renderer>().material;
        if (mat.color == Color.green)
        {
            mat.color = Color.white;
        }
        else
        {
            mat.color = Color.green;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

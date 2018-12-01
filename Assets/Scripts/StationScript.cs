using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Attach this to any station you want to assign a crewmember to.


public class StationScript : MonoBehaviour, IPointerClickHandler
{
    SimpleGameManager GM;
    void Awake()
    {
        GM = SimpleGameManager.Instance;
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        GM.Selected.transform.position = this.transform.position;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShipClickBehavior : MonoBehaviour, IPointerClickHandler {
	SimpleGameManager GM;
	// Use this for initialization
	void Start () {
		GM = SimpleGameManager.Instance;
	}

	public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log("Island Ship clicked");

    }

	// Update is called once per frame
	void Update () {

	}
}

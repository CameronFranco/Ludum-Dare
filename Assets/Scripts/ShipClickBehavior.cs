using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShipClickBehavior : MonoBehaviour, IPointerClickHandler {
	SimpleGameManager GM;
    public GameObject shipCutaway;
    public GameObject scroll;
	public Text Text;
	// Use this for initialization
	void Start () {
		GM = SimpleGameManager.Instance;
	}

	public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log("Island Ship clicked");
        shipCutaway.SetActive(true);
		scroll.SetActive(false);
		Text.text = "";
        
    }

	// Update is called once per frame
	void Update () {

	}
}

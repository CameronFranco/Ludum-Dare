using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShipClickBehavior : MonoBehaviour, IPointerClickHandler {
	SimpleGameManager GM;
    public GameObject prefab;
    public GameObject scroll;
	public Text Text;
    Vector3 pos;
	// Use this for initialization
	void Start () {
        GM = SimpleGameManager.Instance;
        pos = new Vector3(61.4f, 5, -1);
	}

	public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log("Island Ship clicked");
        Instantiate(prefab, pos, Quaternion.identity);
		scroll.SetActive(false);
		Text.text = "";
        
    }

	// Update is called once per frame
	void Update () {

	}
}

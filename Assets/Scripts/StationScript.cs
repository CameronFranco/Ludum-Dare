using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Attach this to any station you want to assign a crewmember to.


public class StationScript : MonoBehaviour, IPointerClickHandler
{
    Vector3 position;
    Vector3 crewmemberPosition;

    SimpleGameManager GM;
    void Awake()
    {
        GM = SimpleGameManager.Instance;
        position = this.transform.position;
        crewmemberPosition = new Vector3(position.x, position.y, (position.z - 10.0f));
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        GM.Selected.transform.position = crewmemberPosition;
        Debug.Log("Station clicked");
        Material mat = GM.Selected.GetComponent<Renderer>().material;
            mat.color = Color.white;
    }
    void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}

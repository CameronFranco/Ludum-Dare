using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuShipReset : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "Ship") {
			Vector2 startLocation = new Vector2(0f,5f);
			other.GetComponent<Rigidbody2D>().position = startLocation;
			GameObject camera = GameObject.Find("Main Camera");
			Rigidbody2D camera_rb = camera.GetComponent<Rigidbody2D>();
			camera_rb.position = startLocation;
		}
	}
}

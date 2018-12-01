using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour {

    private Rigidbody2D rb;

    void Start () {
        rb = gameObject.AddComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.AddForce(new Vector2(70f, 0.0f));
    }
}

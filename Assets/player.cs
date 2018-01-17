using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public float speed = 10f;

    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal")* Time.fixedDeltaTime* speed;

        rb.MovePosition(rb.position + Vector2.right * x);
    }
    
	
	// Update is called once per frame
	void Update () {
		
	}
}

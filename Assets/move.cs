using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
	private float acc = 1f;
    
    public Rigidbody rb;
    

    // Update is called once per frame
	void FixedUpdate() 
	{
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0f, 0f, acc);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0f, 0f, -acc);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-acc, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(acc, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddForce(0f, acc, 0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            rb.AddForce(0f, -acc, 0f);
        }
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
	public float acceleration = 0.001f; 
	public float accSprintMultiplier = 2; 
	public float dampingCoefficient = 5; 
	
	Vector3 velocity; 
    
    

    // Update is called once per frame
	void FixedUpdate() 
	{
		UpdateInput();
		
		velocity = Vector3.Lerp( velocity, Vector3.zero, dampingCoefficient * Time.deltaTime );
		transform.position += velocity;
	}

	void UpdateInput() 
	{
		velocity += GetAccelerationVector() * Time.deltaTime;
	}
    Vector3 GetAccelerationVector() 
	{
		Vector3 moveInput = default;

		void AddMovement( KeyCode key, Vector3 dir )
		{
			if( Input.GetKey( key ) )
				moveInput += dir;
		}

		AddMovement( KeyCode.W, Vector3.down);
		AddMovement( KeyCode.S, Vector3.up);
		AddMovement( KeyCode.D, Vector3.right);
		AddMovement( KeyCode.A, Vector3.left);
		AddMovement( KeyCode.Q, Vector3.forward);
		AddMovement( KeyCode.E, Vector3.back);
		Vector3 direction = transform.TransformVector( moveInput.normalized );

		if( Input.GetKey( KeyCode.LeftShift ) )
			return direction * ( acceleration * accSprintMultiplier ); // "sprinting"
		return direction * acceleration; // "walking"
	}
}
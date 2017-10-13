using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float movespeed = 1.0f;
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		float movehorizontal = Input.GetAxis ("Horizontal");
		float movevertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (movehorizontal, 0.0f, movevertical);
		
		GetComponent<Rigidbody> ().AddForce (movement * movespeed * Time.deltaTime);
	}
}

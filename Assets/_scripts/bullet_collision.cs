using UnityEngine;
using System.Collections;

public class bullet_collision : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	
	void OnCollisionEnter2D (Collision2D other)
	{
		Debug.Log ("hit: " + other.collider.name);
	}
}

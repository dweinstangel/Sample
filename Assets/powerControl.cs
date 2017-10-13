using UnityEngine;
using System.Collections;

public class powerControl : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
	
		void OnCollisionEnter2D (Collision2D coll)
		{
				Debug.Log ("power collision");
				//if (coll.gameObject.name == "bomb") {
				//Destroy (coll.gameObject);
				//this.GetComponent<healthScript> ().health -= 1;
				//}
				if (coll.gameObject.tag == "Player") {
						Destroy (this.gameObject);
				}
		}
}

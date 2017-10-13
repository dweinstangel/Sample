using UnityEngine;
using System.Collections;

public class lvl1_portal : MonoBehaviour
{
		public GameObject thePlayer;
		public GameObject theGate;
		
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
				Debug.Log ("collision");
				//if (coll.gameObject.name == "bomb") {
				//Destroy (coll.gameObject);
				//this.GetComponent<healthScript> ().health -= 1;
				//}
				if (coll.gameObject.tag == "Player") {
						GameObject maze = GameObject.FindGameObjectWithTag ("wall");
						thePlayer.transform.position = theGate.GetComponent<Rigidbody2D>().position;
						maze.transform.position = new Vector3 (maze.transform.position.x, 24.4f);
				}
		}
}
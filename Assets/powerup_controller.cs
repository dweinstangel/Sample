using UnityEngine;
using System.Collections;

public class powerup_controller : MonoBehaviour
{
		public AudioSource bounce_sound;
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
				Debug.Log ("collision powerup");
				//if (coll.gameObject.name == "bomb") {
				//Destroy (coll.gameObject);
				//this.GetComponent<healthScript> ().health -= 1;
				//}
				if (coll.gameObject.tag == "ball") {
						bounce_sound.Play ();
				}
				//Instantiate (explosion, transform.position, transform.rotation);
				//explode_sound.Play ();
		}
}

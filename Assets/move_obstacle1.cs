using UnityEngine;
using System.Collections;

public class move_obstacle1 : MonoBehaviour
{
		bool isGoingLeft = false;
	
		void Start ()
		{
		}
	
		void OnTriggerEnter2D (Collider2D other)
		{
		
				Debug.Log ("collision");
				//if (coll.gameObject.name == "bomb") {
				//Destroy (coll.gameObject);
				//this.GetComponent<healthScript> ().health -= 1;
				//}
				if (other.gameObject.tag == "wall") {
						if (isGoingLeft == false) {
								Debug.Log ("left");
								isGoingLeft = true;
						} else {
								Debug.Log ("right");
								isGoingLeft = false;
						}
				}
		}
		
		void Update ()
		{
				if (isGoingLeft == false) {
						transform.Translate (+0.01f, 0, 0);
				} else {
						transform.Translate (-0.01f, 0, 0);
				}
		}
}
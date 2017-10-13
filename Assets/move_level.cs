using UnityEngine;
using System.Collections;

public class move_level : MonoBehaviour
{
		private float myDif;
		private Vector3 startPosition;
	
		// Use this for initialization
		void Start ()
		{
				startPosition = GameObject.FindGameObjectWithTag ("MainCamera").transform.position;
		}
	
		// Update is called once per frame
		void Update ()
		{
/*				float zHold = GameObject.FindGameObjectWithTag ("sphere").transform.position.z;
				float upperLimit = -12.0f;
				float lowerLimit = -17.0f;
				if (zHold >= upperLimit) {
						myDif = zHold - upperLimit;
						transform.position = new Vector3 (0.0f, 1.0f, 0.0f);
				}
				if (zHold <= lowerLimit) {
						myDif = GameObject.FindGameObjectWithTag ("sphere").transform.position.z + -16.0f;
						transform.position = new Vector3 (0.0f, transform.position.y + myDif, 0.0f);
				}
*/		
		}
}

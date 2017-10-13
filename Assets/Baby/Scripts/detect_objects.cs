using UnityEngine;
using System.Collections;

public class detect_objects : MonoBehaviour
{
		public float topClamp = 2.75f;
		public float botClamp = -0.58f;
			
		// Update is called once per frame
		void Update ()
		{
		}
		
		void FixedUpdate ()
		{
				if (GetComponent<Rigidbody2D>().position.y >= topClamp || GetComponent<Rigidbody2D>().position.y <= botClamp) {
						Debug.Log ("clamp top bottom");
			
						Vector3 pos = GetComponent<Rigidbody2D>().position;
						pos.y = Mathf.Clamp (pos.y, topClamp, botClamp);
						GetComponent<Rigidbody2D>().position = pos;			
				}
		
		}
}

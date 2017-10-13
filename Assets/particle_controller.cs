using UnityEngine;
using System.Collections;

public class particle_controller : MonoBehaviour
{
		public static bool startPlay = false;
		public ParticleSystem ImpactTest;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (startPlay == true) {
						Instantiate (ImpactTest, transform.position, transform.rotation);
						startPlay = false;
				}
		}
}

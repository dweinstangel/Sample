using UnityEngine;

public class heartburst_control : MonoBehaviour
{
		static public bool starteffect;
		public ParticleSystem Particle_Name;
		// Use this for initialization
		void Start ()
		{
				starteffect = false;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (starteffect == true) {
						if (!Particle_Name.isPlaying) {
								Particle_Name.Play ();
						}
						//Instantiate (Particle_Name, transform.position, transform.rotation);
						starteffect = false;
				}
		}
}

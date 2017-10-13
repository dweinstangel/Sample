using UnityEngine;
using System.Collections;

public class Baby_Control : MonoBehaviour
{
		public static float movespeed;
		private Vector3 moveDirection;
		public float turnSpeed;
		private Vector3 tPos;
		private int Right_Clamp = Screen.width;
		public AudioClip babyContactSound;
		public ParticleSystem Particle_Name;
		private bool starteffect;		
		//public Animator myTransport;
		public bool transflag = false;
		
		// Use this for initialization
		void Start ()
		{
				Particle_Name = this.GetComponent <ParticleSystem> ();
				moveDirection = Vector3.right;
				starteffect = false;
		}
	
		// Update is called once per frame
		void Update ()
		{
				Vector3 currentPosition = transform.position;
				movespeed = Random.Range (0, 2);
				Vector3 target = moveDirection * movespeed + currentPosition;
				transform.position = Vector3.Lerp (currentPosition, target, Time.deltaTime);
		}
		
		Vector3 getLocation ()
		{
				return transform.position;
		}
		
		void OnTriggerEnter2D (Collider2D other)
		{
				if (other.tag == "exit") {
						if (scoretext.thescore > 0) {
								scoretext.thescore -= 1;
								heartburst_control.starteffect = true;
						} else if (scoretext.thescore < 1) {
								if (gameover.gameend == false) {
										gameover.gameend = true;	
								}
						}
						babyexit.flag = true;
						Destroy (this.gameObject);
				}
		}
}
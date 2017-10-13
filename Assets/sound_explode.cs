using UnityEngine;
using System.Collections;

public class sound_explode : MonoBehaviour
{
		public static bool playsound = false;
		private AudioSource mysound;
		
		// Use this for initialization
		void Start ()
		{
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (playsound == true) {
						mysound.Play ();
						playsound = false;
				}
		}
}

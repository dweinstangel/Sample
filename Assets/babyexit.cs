using UnityEngine;
using System.Collections;

public class babyexit : MonoBehaviour
{
		static public bool flag;
		public AudioClip babyContactSound;
		// Use this for initialization
		void Start ()
		{
				flag = false;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (flag == true) {
						GetComponent<AudioSource>().PlayOneShot (babyContactSound);
						transport_effect.starteffect = true;
						flag = false;
				}
		}
}

using UnityEngine;
using System.Collections;

public class Baby_Hit : MonoBehaviour
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
						flag = false;
				}
		}
		
		public void playsound ()
		{
				flag = true;
		}
}

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class audio_controller : MonoBehaviour
{
		// Use this for initialization
		void Start ()
		{
				GetComponent<AudioSource>().volume = 0.5f;
				GetComponent<AudioSource>().Play ();
				//audio.Play ();
				Debug.Log ("audio");
		}
	
		// Update is called once per frame
		void Update ()
		{
		}
}

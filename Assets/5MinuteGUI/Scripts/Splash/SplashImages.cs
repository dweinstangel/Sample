using UnityEngine;
using System.Collections;

public class SplashImages : MonoBehaviour
{

		public BaseImage[] splashImages;
		float audio1Volume = 1.0f;
		
		public void Start ()
		{
				StartCoroutine (handleSplashImages ());
				GetComponent<AudioSource>().Play ();
		}
		// Use this for initialization
		IEnumerator handleSplashImages ()
		{
				for (int i=0; i<splashImages.Length; i++) {
						splashImages [i].gameObject.SetActive (true);
						yield return new WaitForSeconds (splashImages [i].play ());
						yield return new WaitForSeconds (5);
						yield return new WaitForSeconds (splashImages [i].hide ());
				}
				fadeOut ();				
				Application.LoadLevel (Application.loadedLevel + 1);
		}
		
		void fadeOut ()
		{
				float i = audio1Volume;
				do {
						i -= 0.1f * Time.deltaTime;
						GetComponent<AudioSource>().volume = i;
				} while(i>= 0.0f);
				GetComponent<AudioSource>().Stop ();
				GetComponent<AudioSource>().volume = 1;
//				if (audio1Volume > 0.1f) {
//						audio1Volume -= 0.1f * Time.deltaTime;
//						audio.volume = audio1Volume;
//				}

		}
}
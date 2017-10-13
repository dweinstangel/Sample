using UnityEngine;
using System.Collections;

public class Options_Controller : MonoBehaviour
{
		private static bool onPause = false;
		private Animator myAnimator;
		private int myInt;
		// Use this for initialization
		void Start ()
		{
				myAnimator = this.GetComponent<Animator> ();
				myAnimator.SetInteger ("change", Mathf.Abs (0));
				myAnimator.enabled = false;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKeyDown (KeyCode.Escape)) {
						myInt = myAnimator.GetInteger ("change");
						myAnimator.enabled = true;
						if (onPause == true) {
								if (myInt == 1) {
										myAnimator.SetInteger ("change", Mathf.Abs (2));
								}
								onPause = false;
								Time.timeScale = 1.0f;
								Music_Slider.showslider = false;
								SoundFX_Slider.showslider = false;
						} else {
								if (myInt == 0 || myInt == 2) {
										myAnimator.SetInteger ("change", Mathf.Abs (1));
								}
						}
						
				}
		}
		
		public void stopTime ()
		{
				onPause = true;
				Music_Slider.showslider = true;				
				SoundFX_Slider.showslider = true;
				if (Music_Slider.hSliderValue == 0.0f) {
						Music_Slider.hSliderValue = 0.10f;
				}
				Time.timeScale = 0.0f;
		}
}

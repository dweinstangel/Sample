using UnityEngine;
using System.Collections;

public class Music_Slider : MonoBehaviour
{
		public static bool showslider = false;
		public static float hSliderValue = 0.05F;
		//public float tSliderValue = 0.0F;
		
		//private string tHold;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
		}
	
		void OnGUI ()
		{
				if (showslider == true) {
						hSliderValue = GUI.HorizontalSlider (new Rect (210, 197, 260, 30), hSliderValue, 0.0F, 1.0F);
						GetComponent<AudioSource> ().volume = hSliderValue;
				}	
				//tSliderValue = Mathf.Round (hSliderValue * 100f);
				//tHold = hSliderValue.ToString ();
				//GUI.Label (new Rect (160, 172, 100, 40), "Music: " + tSliderValue);
				//slider_value = GUI.HorizontalSlider (Rect (25, 25, 100, 30), slider_value, 0.0, 1.0);
				//GUI.Label (Rect (100, 100, 200, 20), "Value=" + slider_value);
				//audio.volume = slider_value;
		}
		
		public void mute ()
		{
				//audio.mute = true;

		}
		
		public void unmute ()
		{
				//audio.mute = false;
		}
}

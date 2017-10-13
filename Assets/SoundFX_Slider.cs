using UnityEngine;
using System.Collections;

public class SoundFX_Slider : MonoBehaviour
{
		public static bool showslider = false;
		public static float hSliderValue = 0.05F;
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
						hSliderValue = GUI.HorizontalSlider (new Rect (210, 228, 260, 30), hSliderValue, 0.0F, 1.0F);
						GetComponent<AudioSource> ().volume = hSliderValue;			
				}
		}
}

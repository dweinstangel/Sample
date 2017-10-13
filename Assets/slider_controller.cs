using UnityEngine;
using System.Collections;

public class slider_controller : MonoBehaviour
{
		public GUIStyle backgroundStyle;
		public GUIStyle thumbStyle;
		public Texture2D tex, thumbTex;
		
		private float sliderValue;
		float maxSliderValue = 10.0f;
		
		void Start ()
		{
		}
		
		void OnGUI ()
		{
//				GUILayout.BeginHorizontal (Rect (25, 25, 250, 25), tex);
				
//				GUILayout.Box ("sliderValue: " + Mathf.RoundToInt (sliderValue), text);
			
				thumbStyle.normal.background = thumbTex;
				thumbStyle.fixedWidth = 30;
				thumbStyle.fixedHeight = 30;

				backgroundStyle.normal.background = tex;
				GUILayout.EndHorizontal ();
				if (Mathf.RoundToInt (sliderValue) == 1) {
				
				} else {
			
				}
			
				sliderValue = GUILayout.HorizontalSlider (sliderValue, 0f, maxSliderValue, backgroundStyle, thumbStyle, GUILayout.Width (200), GUILayout.Height (25));
		}
}
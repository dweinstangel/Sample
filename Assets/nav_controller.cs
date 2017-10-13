using UnityEngine;
using System.Collections;

public class nav_controller : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
					
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
	
		public void onStartClick ()
		{
				Debug.Log ("click start");
				Application.LoadLevel ("slider_scene");
		}
		
		void onGUI ()
		{
						
		}
}

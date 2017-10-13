using UnityEngine;
using System.Collections;

public class setscore : MonoBehaviour
{
		public static string scoreText;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
	
		void onGUI ()
		{
				GetComponent<GUIText>().text = scoreText;
		}
}

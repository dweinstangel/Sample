using UnityEngine;
using System.Collections;

public class btnExitClick : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
	
		public void btnExitGameClick ()
		{
				Time.timeScale = 1;		
				Application.LoadLevel (0);
		}
}

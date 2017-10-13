using UnityEngine;
using System.Collections;

public class trigger_startpanel : MonoBehaviour
{
		public Animator myAnim;
		private bool playstop = true;
		// Use this for initialization
		void Start ()
		{
				myAnim = GetComponent<Animator> ();
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
	
		private void triggerStart ()
		{
				if (playstop == true) {
						movepanel.moveFlag = true;
						playstop = false;
				}
		}
}

using UnityEngine;
using System.Collections;

public class gameover : MonoBehaviour
{
		public static bool gameend = false;
		private Animator myAnimator;
		private int myInt;
		private bool isPlaying = false;
	
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
				if (gameend == true) {
						if (isPlaying == false) {
								myAnimator.SetInteger ("change", Mathf.Abs (1));
								myAnimator.enabled = true;
								isPlaying = true;
						}
				}
		}
		
		public void stopPlaying ()
		{
				myAnimator.SetInteger ("change", Mathf.Abs (0));
				myAnimator.enabled = false;
				Time.timeScale = 0.0f;
		}
}

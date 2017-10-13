using UnityEngine;
using System.Collections;

public class Game_Over_Control : MonoBehaviour
{
		public static bool playFlag = false;
		Animator myAnim;
		// Use this for initialization
		void Start ()
		{
				myAnim = GetComponent<Animator> ();
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (playFlag == true) {
						myAnim.Play ("Game_Over");
						playFlag = false;
				}
		}
}

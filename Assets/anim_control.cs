using UnityEngine;
using System.Collections;

public class anim_control : MonoBehaviour
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
			myAnim.Play ("btnGameOver");
			playFlag = false;
		}
	}
		
	public void stopTime ()
	{
		Time.timeScale = 0;
	}
}
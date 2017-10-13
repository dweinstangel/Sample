using UnityEngine;
using System.Collections;

public class movepanel : MonoBehaviour
{
		static public bool moveFlag = false;
		// Use this for initialization
		void Start ()
		{
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (moveFlag == true) {
						moveFlag = false;
				}
		}
}

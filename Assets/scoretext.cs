using UnityEngine;
using System.Collections;

public class scoretext : MonoBehaviour
{
		static public int thescore;
		// Use this for initialization
		void Start ()
		{
				thescore = 2 + init_game.level;
		}
	
		// Update is called once per frame
		void Update ()
		{
				GetComponent<GUIText> ().text = thescore.ToString ();
		}
}

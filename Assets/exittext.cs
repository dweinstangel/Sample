using UnityEngine;
using System.Collections;

public class exittext : MonoBehaviour
{
		static public int thescore;
		// Use this for initialization
		void Start ()
		{
				thescore = 0;
		}
	
		// Update is called once per frame
		void Update ()
		{
				GetComponent<GUIText> ().text = thescore.ToString ();
		}
}
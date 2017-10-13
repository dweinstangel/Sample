using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cd_text : MonoBehaviour
{
		Text myText	;	
		// Use this for initialization
		void Start ()
		{
				myText = GetComponent<Text> ();
				myText.text = "3";
				panel_drop.start_drop = false;
				//myText = GetComponent<guiText>;
				//guiText.text = cdText;
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}
		
		public void start_maze ()
		{
				panel_drop.start_drop = true;
		}
		
		public void countdown1 ()
		{
				myText.text = " 1";
		}
		
		public void countdown2 ()
		{
				myText.text = "2";
		}
		
		public void countdown3 ()
		{
				myText.text = "3";
		}
}

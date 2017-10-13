using UnityEngine;
using System.Collections;

public class init_game : MonoBehaviour
{
		public static string[] shelf_items = { "", "", "onesie", "bottle_grow" };
		public static int shelf_selected = 0;
		public static bool isPlaying = false;
		public static bool isConfirmed = false;
		public static bool gameOver = false;
		public static int level = 1;
	
		// Use this for initialization
		void Start ()
		{
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
	
		public static string getShelfItem (long theItem)
		{
				string tHold = shelf_items.GetValue (theItem - 1).ToString ();
				return tHold;
		}
}
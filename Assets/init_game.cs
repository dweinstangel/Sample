using UnityEngine;
using System.Collections;

public class init_game2 : MonoBehaviour
{
		public static float player_health;
//		public GUIBarScript mybar;
		// Use this for initialization
		void Start ()
		{
				player_health = 1.0f;
//				mybar = gameObject.GetComponent <GUIBarScript>;
				//Time.timeScale = 0;
				//audio_controller.sounds = 0;
		}
	
		// Update is called once per frame
		void Update ()
		{
			
		}
		
		public void addHealth ()
		{
/*				if (player_health < 1.0f) {
						player_health = player_health + 0.1f;
						mybar.SetNewValue = player_health;
				}*/
		}
		
		public void remHealth ()
		{
				/*		if (player_health > 0.0f) {
						player_health = player_health - 0.1f;
						mybar.SetNewValue = player_health;
				}*/
		}
		
		float getHealth ()
		{
				return player_health;
		}
}

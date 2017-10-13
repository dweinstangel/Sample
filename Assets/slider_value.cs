using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class slider_value : MonoBehaviour
{
		public static float myHealth = 1f;
		private Slider tempgo;
		// Use this for initialization
		void Start ()
		{
				tempgo = this.gameObject.GetComponent<Slider> ();
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				tempgo.value = myHealth;
		}
}

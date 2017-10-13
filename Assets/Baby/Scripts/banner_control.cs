using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class banner_control : MonoBehaviour
{
		public string publisherId = "a1510269fda61bf";
		public float refreshRate = 60.0f;
		public string testDevice = "test_device_code_here";
		
		// Use this for initialization
		void Start ()
		{
				AdBannerObserver.Initialize (publisherId, testDevice, refreshRate);
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}

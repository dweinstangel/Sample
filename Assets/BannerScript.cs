using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class BannerScript : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
				BannerView bannerView = new BannerView (
			"ca-app-pub-5208394338681561/4916387337", AdSize.Banner, AdPosition.Top);
				AdRequest request = new AdRequest.Builder ()
			.AddTestDevice (AdRequest.TestDeviceSimulator)       // Simulator.
				//	.AddTestDevice("0123456789ABCDEF0123456789ABCDEF")  // Test Device 1.
				.Build ();
				//	AdRequest request = new AdRequest.Builder ().Build ();
				bannerView.LoadAd (request);
				bannerView.Show ();
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}

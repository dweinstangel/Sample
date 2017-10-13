using UnityEngine;
using System.Collections;

public class touch_grow : MonoBehaviour
{

		private Vector3 screenPoint;
		private Vector3 offset;
		private Animator animator;
		public ParticleSystem Particle_Name;
		private bool starteffect;
		private bool itemlocked;

		void Start ()
		{
				animator = this.GetComponent<Animator> ();
				//particle = this.GetComponent<ParticleSystem> ();
				starteffect = false;
		}	
		
		void Update ()
		{
				if (starteffect == true) {
						Particle_Name.Play ();
						print ("play");
						//Instantiate (Particle_Name, transform.position, transform.rotation);
						starteffect = false;
				}		
		}
	
		void OnMouseDown ()
		{
				if (itemlocked == false) {
						screenPoint = Camera.main.WorldToScreenPoint (gameObject.transform.position);
						offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
						animator.SetInteger ("change", Mathf.Abs (1));
				}
		}

		void OnMouseDrag ()
		{
				if (itemlocked == false) {
						Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
						Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
						transform.position = curPosition;
				}
				//animator.Play ("Bottle_Grow");				
		}
		
		void OnMouseUp ()
		{
				//Debug.Log ("Bottle_Shrink");
				//animator.Play ("Bottle_Shrink");			
				if (animator.GetInteger ("change") == 1) {
						animator.SetInteger ("change", Mathf.Abs (2));
						StartCoroutine (itemCountdown ());
				}
		}
		
		IEnumerator itemCountdown ()
		{
				print (Time.time);
				yield return new WaitForSeconds (4);
				print (Time.time);
				if (animator.GetInteger ("change") == 2) {
						starteffect = true;
						itemlocked = true;
				}
		}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("enter trigger");
        if (other.gameObject.name == "baby_walking")
        {
            Debug.Log("baby_detected");
        }
    }

}
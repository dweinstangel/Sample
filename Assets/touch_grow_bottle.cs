using UnityEngine;
using System.Collections;

public class touch_grow_bottle : MonoBehaviour
{

		private Vector3 screenPoint;
		private Vector3 offset;
		public Animator animator;

		void Start ()
		{
				animator = this.GetComponent<Animator> ();
		}	
		
		void Update ()
		{
		}
	
		void OnMouseDown ()
		{
				screenPoint = Camera.main.WorldToScreenPoint (gameObject.transform.position);
				offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
				animator.SetInteger ("change", Mathf.Abs (1));
		}

		void OnMouseDrag ()
		{
				Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
				Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
				transform.position = curPosition;
				//animator.Play ("Bottle_Grow");
				animator.SetInteger ("change", Mathf.Abs (2));			
		}
		
		void OnMouseUp ()
		{
				//Debug.Log ("Bottle_Shrink");
				//animator.Play ("Bottle_Shrink");			
				if (animator.GetInteger ("change") == 1) {
						animator.SetInteger ("change", Mathf.Abs (2));
				}
		}
}
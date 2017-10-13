using UnityEngine;
using System.Collections;

public class item_touch_drag : MonoBehaviour
{
	private Vector3 mousePosition;
	public float moveSpeed = 0.1f;
	private Collider2D myCollider;
	
	// Use this for initialization
	void Start ()
	{
		myCollider = GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		bool dragging = false;
		//if(!isGameOver) {
		if (Input.GetMouseButton (0)) {
			mousePosition = Input.mousePosition;
			mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);

			if (myCollider.OverlapPoint (mousePosition)) {
				dragging = true;
				transform.position = Vector2.Lerp (transform.position, mousePosition, moveSpeed * Time.fixedDeltaTime);
			} else {
				if (dragging == true) {
					transform.position = Vector2.Lerp (transform.position, mousePosition, moveSpeed * Time.fixedDeltaTime);
				}
			}
		}
		if (transform.position.y > 3.0f) {
			transform.position = new Vector2 (transform.position.x, 3.0f);
		}
		if (transform.position.y < -3.0f) {
			transform.position = new Vector2 (transform.position.x, -3.0f);
		}
		
		if (Input.GetMouseButtonUp (0)) {
			//transform.position = new Vector3 (orig_pos_x, orig_pos_y);
			dragging = false;
		}
	}
	
}
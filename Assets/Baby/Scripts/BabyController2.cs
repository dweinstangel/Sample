using UnityEngine;
using System.Collections;

public class BabyController : MonoBehaviour
{
	public float moveSpeed = 2;
	private Vector3 moveDirection;
	public float turnSpeed = 5;
	private int thescore = 0;
	public float speed = 1;
	public float Right_Clamp = 4;	
	// Use this for initialization
	void Start ()
	{
	}

	// Update is called once per frame
	void Update ()
	{
		transform.position += Vector3.right * speed * Time.deltaTime;			
		if (Input.GetButton ("Fire1")) {
			Vector3 pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (pos, Vector2.zero);
			if (hit != null && hit.collider != null) {
				Debug.Log ("I'm hitting " + hit.collider.name);
				Destroy (hit.collider.gameObject);
				thescore += 1;
				Debug.Log ("theScore: " + thescore);	
			}				
		}
		if (GetComponent<Rigidbody2D>().position.x >= 6) {
			Debug.Log ("clamp right");
			DestroyObject (this.gameObject);			
		}		
	}
}
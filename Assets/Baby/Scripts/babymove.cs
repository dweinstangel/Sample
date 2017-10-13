	using UnityEngine;
using System.Collections;

public class babymove : MonoBehaviour
{
	public float speed = 1;
	public float Right_Clamp = 4;
	
	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Baby created!");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.touchCount == 1) {
			Debug.Log ("Screen touched");
			Vector3 wp = Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position);
			Vector2 touchPos = new Vector2 (wp.x, wp.y);
			if (GetComponent<Collider2D>() == Physics2D.OverlapPoint (touchPos)) {
				Debug.Log ("----------> Touched !");
							
			}
		}	
		
		if (GetComponent<Rigidbody2D>().position.x >= 6) {
			Debug.Log ("clamp right");
			
			//Vector3 pos = rigidbody2D.position;
			//pos.x = Mathf.Clamp (pos.x, -5.40f, Right_Clamp);
			//rigidbody2D.position = pos;			
			DestroyObject (this.gameObject);			
		}
		transform.position += Vector3.right * speed * Time.deltaTime;		
	}
}

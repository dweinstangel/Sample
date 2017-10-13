using UnityEngine;
using System.Collections;

public class MoveToExit : MonoBehaviour {
	public Vector3 target;
	public float speed;
	public Vector3 startingPosition;
	//This would be attached to the object itself.
	private float timeToDestination = 2f; // the f makes the 2 a float
	private bool currentlyAnimating = false;
	// Use this for initialization


	void Start () {
		speed = 1f;
		startingPosition = transform.position;
		target = GameObject.Find("Door").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//float step = speed * Time.deltaTime;
		//if(!this.currentlyAnimating){
		//	StartCoroutine(MoveThis(target));
		//}
	}

	void FixedUpdate() {
		//rigidbody2D.MovePosition(rigidbody2D.position + speed * Time.deltaTime);
		//float step = speed * Time.deltaTime;
		if(!this.currentlyAnimating){
			StartCoroutine(MoveThis(target));
		}
	}

	private IEnumerator MoveThis(Vector3 destinationPosition) {
		Vector3 startPosition = this.transform.position;
		this.currentlyAnimating = true;
		float scale = 1f / this.timeToDestination;
		float i = 0f;
		while(i < 1f){
			i += Time.deltaTime * scale;
			this.transform.position = Vector3.Lerp(startPosition, destinationPosition, i);
			yield return null;
		}
		this.currentlyAnimating = false;
	}
}

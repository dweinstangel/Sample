using UnityEngine;
using System.Collections;

public class panel_drop : MonoBehaviour
{
		public float moveSpeed = 0.9f;
		private Vector3 moveDirection;
		private bool spawnit;
		public Transform obstacle = null;
		private Transform mySprite;
		public static bool start_drop = false;
		
		// Use this for initialization
		void Start ()
		{
				spawnit = true;
				if (this.gameObject.name == "maze_wall3(Clone)") {
						mySprite = (Transform)Instantiate (obstacle, new Vector3 (-1.4f, 0, 0), Quaternion.identity);
				}
				//Instantiate (obstacle, new Vector3 (-1.4f, 0, 0), Quaternion.identity);
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (start_drop == true) {
						transform.position += Vector3.down * moveSpeed * Time.deltaTime;
						if (this.gameObject.name == "maze_wall3") {
								mySprite.transform.position += Vector3.down * moveSpeed * Time.deltaTime;		
						}
						if (transform.position.y <= -63f) {	
								if (this.gameObject.name == "maze_wall3") {
										Destroy (mySprite.gameObject);
								}
								Destroy (this.gameObject);
						}
						if (transform.position.y <= 1.25000f) {
								if (spawnit == true) {
										maze_library.myValue = true;
										spawnit = false;
								}
						}
				}
		}
}

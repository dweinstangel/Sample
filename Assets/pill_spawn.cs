using UnityEngine;
using System.Collections;

public class pill_spawn : MonoBehaviour
{
	
		public float spawnTime = 1f;
		public float spawnDelay = 15f;
		public GameObject[] pillobject;
	
		// Use this for initialization
		void Start ()
		{
				//spawnDelay = Random.Range (4f, 25f);
				//spawnTime = Random.Range (4f, 25f);
				//				Debug.Log (spawnDelay.ToString);
				//InvokeRepeating ("Spawn", spawnDelay, spawnTime);
				InvokeRepeating ("Spawn", spawnTime, spawnDelay);
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}
	
		void Spawn ()
		{
				int pillIndex = Random.Range (0, pillobject.Length);
		
				Instantiate (pillobject [pillIndex], transform.position, transform.rotation);
				pillobject [pillIndex].GetComponent<Rigidbody2D>().gravityScale = 0.01f;
		}
}

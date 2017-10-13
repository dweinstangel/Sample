using UnityEngine;
using System.Collections;

public class Baby_Spawner1 : MonoBehaviour
{

	public float spawnTime = 5f;
	public float spawnDelay = 3f;
	public GameObject[] babies;
	private int previousScore = 0;
	public int totalScore = 10;
				
	// Use this for initialization
	void Start ()
	{
		spawnDelay = Random.Range (4f, 25f);
		spawnTime = Random.Range (4f, 25f);
//				Debug.Log (spawnDelay.ToString);
		InvokeRepeating ("Spawn", spawnDelay, spawnTime);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}
	
	void Spawn ()
	{
		int babyIndex = Random.Range (0, babies.Length);
				
		Instantiate (babies [babyIndex], transform.position, transform.rotation);
	}
}

using UnityEngine;
using System.Collections;

public class Baby_Spawner : MonoBehaviour
{
		public float babySpawnTime = 5f;
		public float babySpawnDelay = 3f;
		public GameObject[] babies;
		public int totalScore = 10;
		private Object clone;
		public int waveCount = 1;
		private int gameLevel;
		public int waveCooldown = 10;
		
	
		// Use this for initialization
		void Start ()
		{
				//				Debug.Log (spawnDelay.ToString);
				//InvokeRepeating ("Spawn", spawnDelay, spawnTime);
				LevelSettings ();
		}
	
		void LevelSettings ()
		{
				gameLevel = init_game.level;
				babySpawnDelay = 1f;
				babySpawnTime = 1f;
				scoretext.thescore = gameLevel * (10 / 2);
		}
		
		// Update is called once per frame
		void Update ()
		{
				if (gameover.gameend == true) {
					Destroy (clone);
				}
		}
	
		void Spawn ()
		{
				if (!init_game.gameOver == true) {
						int babyIndex = Random.Range (0, gameLevel - 1);
						clone = Instantiate (babies [babyIndex], transform.position, transform.rotation);
						clone.name = "baby_walking";						
				}
		}
}
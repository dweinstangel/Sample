using UnityEngine;
using System.Collections;

public class maze_library : MonoBehaviour
{
		public Transform[] pieces;
		public float spawnTime = 1f;
		private Vector3 spawnPos;
		private int MazeIndex = 0;
		public static bool myValue = false;
		private int mazePiece = 0;
		// Use this for initialization
		void Start ()
		{
				Time.timeScale = 1;
				Invoke ("Spawn", spawnTime);
				spawnPos.x = 0.0f;
				spawnPos.y = 3.5f;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (myValue == true) {
						Invoke ("Spawn", spawnTime);
						myValue = false;
				}
		}

		void Spawn ()
		{
				if (MazeIndex >= pieces.Length) {
						MazeIndex = 0;
				} else {
						Instantiate (pieces [MazeIndex], spawnPos, transform.rotation);
						MazeIndex += 1;
			
				}
		}
}

﻿using UnityEngine;
using System.Collections;

public class CameraSmoothFollow : MonoBehaviour
{
	public GameObject cameraTarget; // object to look at or follow
	public GameObject player; // player object for moving
	
	public float smoothTime = 0.1f;    // time for dampen
	public bool cameraFollowX = true; // camera follows on horizontal
	public bool cameraFollowY = true; // camera follows on vertical
	public bool cameraFollowZ = true; // camera follows on z axis
	public bool cameraFollowHeight = true; // camera follow CameraTarget object height
	public float cameraHeight = 2.5f; // height of camera adjustable
	public Vector3 velocity; // speed of camera movement
	
	private Transform thisTransform; // camera Transform
	
	// Use this for initialization
	void Start ()
	{
		thisTransform = transform;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (cameraFollowX) {
			thisTransform.position = new Vector3 (Mathf.SmoothDamp (thisTransform.position.x, cameraTarget.transform.position.x, ref velocity.x, smoothTime), thisTransform.position.y, thisTransform.position.z);
		}
		if (cameraFollowY) {
			// to do  
		}
		if (cameraFollowZ) {
			thisTransform.position = new Vector3 (thisTransform.position.x, thisTransform.position.y, Mathf.SmoothDamp (thisTransform.position.z, cameraTarget.transform.position.z, ref velocity.z, smoothTime));
		}
		if (!cameraFollowX & cameraFollowHeight) {
			// to do
		}
	}
}

using UnityEngine;
using System.Collections;
using System.Linq;

public class touch_panel_controller : MonoBehaviour
{
	public GameObject panel;
	private int panel_count;
//	private IList panel_holder;
//	private Transform[] panel_positions;
	
	// Use this for initialization
	void Start ()
	{	
		//panel_holder = new IList ();
		
		/*
		if (init_game.level == 1) {
			panel_count = 12;
		}
		*/
		
//		panel_positions = new Transform[panel_count - 1];
		//panel_holder = new Object[panel_count - 1];		
		
/*		panel_holder [0].Transform.position = new Vector3 (1.4f, 0.33f, 0.0f);
		panel_positions [1].position = new Vector3 (3.03f, 0.33f, 0.0f);
		panel_positions [2].position = new Vector3 (4.64f, 0.33f, 0.0f);
		panel_positions [3].position = new Vector3 (6.26f, 0.33f, 0.0f);
		panel_positions [4].position = new Vector3 (1.4f, -1.1f, 0.0f);
		panel_positions [5].position = new Vector3 (3.03f, -1.1f, 0.0f);
		panel_positions [6].position = new Vector3 (4.64f, -1.1f, 0.0f);
		panel_positions [7].position = new Vector3 (6.26f, -1.1f, 0.0f);		
		panel_positions [8].position = new Vector3 (1.4f, -2.57f, 0.0f);
		panel_positions [9].position = new Vector3 (3.03f, -2.57f, 0.0f);
		panel_positions [10].position = new Vector3 (4.64f, -2.57f, 0.0f);
		panel_positions [11].position = new Vector3 (6.26f, -2.57f, 0.0f);		
		
		for (int i=0; i < panel_count; i++) {
			panel_holder [i] = panel;	
			panel_holder [0] = Instantiate (panel, panel_positions [i].position, Quaternion.identity);		
		}
		Debug.Log ("panels initialized");
	}
*/
	}
	/*private void PoolSystem (int size, GameObject prefab)
	{
		panel_holder = new IList<GameObject> ();
		for (int i = 0; i < size; i++) {
			GameObject obj = (GameObject)Instantiate (prefab);
			panel_holder.Add (obj);
		}
	}
	
	public GameObject GetObject ()
	{
		if (panel_holder.Count > 0) {
		
		}
	}*/
	
	// Update is called once per frame
/*	void Update ()
	{
//		child_count ();
	}
*/	
/*	int child_count ()
	{
		int theCount = 0;
		
		theCount = transform.childCount;
		return theCount;
	}
*/
	void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log ("trigger enter");
	}

	void OnMouseDown ()
	{
		string myName = "";
		string myTag = "";
		
		myName = this.name;
		myTag = this.tag;
		
		if (panel_trigger.light_count > 0) {
			if (myTag == "panel") {
				//Instantiate (shelf_item, this.transform.position);
			}
			 
		}		
	}
}
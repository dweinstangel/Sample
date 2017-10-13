using UnityEngine;
using System.Collections;
using System.Linq;

[RequireComponent(typeof(BoxCollider2D))]

public class hold_item : MonoBehaviour
{
	public static string panel_name	;
	public static string panel_tag;
	private Vector3 screenPoint;
	private Vector3 offset;
	private string tagname;
	private bool can_move;
	private Vector3 start_pos;
	private SpriteRenderer sprite;	
	private bool allow_place = false;

				
	void Start ()
	{
		can_move = true;
		//myLight = GetComponent<Light> ();
		
		//start_pos = transform.position;
		//sprite = GetComponent<SpriteRenderer> ();
	}
	
	void OnMouseDown ()
	{
		//myLight.range = 1.6f;
		//sprite.sortingOrder = 1;
		//screenPoint = Camera.main.WorldToScreenPoint (gameObject.transform.position);
		//offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector2 (Input.mousePosition.x, Input.mousePosition.y));
	}
		
	void OnMouseUp ()
	{
	}	
}
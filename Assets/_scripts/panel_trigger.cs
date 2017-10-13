using UnityEngine;
using System.Collections;

public class panel_trigger : MonoBehaviour
{
	private Light myLight;
	private Light otherLight;
	private bool lit_shelf = false;
	static public int light_count = 0;
	private Sprite shelf_item;
	public Transform[] shelf_sprites;
	public Transform active_sprite;
	public ParticleSystem shimmer;
	private string panelID = "";
	
	// Use this for initialization
	void Start ()
	{
		myLight = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	public int getLightCount ()
	{
		return light_count;
	}
	
	void OnMouseDown ()
	{
		string myName = "";
		string myTag = "";
		string[] panelString = null;
		char[] splitchar = { '_' };
		Sprite shelf_object = new Sprite ();
		myName = this.name;
		myTag = this.tag;
		string shelf_item_name = "";
		
		if (myName == "shelf_1") {
			if (myLight) {
				if (myLight.range > 0.0f) {
					myLight.range = 0.0f;
					light_count -= 1;
					init_game.shelf_selected = 0;
				} else {
					if (light_count > 0) {
						
					} else {
						myLight.range = 1.6f;
						light_count += 1;		
						init_game.shelf_selected = 1;		
					}
				}
			}
		} else if (myName == "shelf_2") {
			if (myLight) {
				if (myLight.range > 0.0f) {
					myLight.range = 0.0f;
					light_count -= 1;
					init_game.shelf_selected = 0;
				} else {
					if (light_count > 0) {
						
					} else {
						myLight.range = 1.6f;
						light_count += 1;		
						init_game.shelf_selected = 2;		
					}
				}
			}		
		} else if (myName == "shelf_3") {
			if (myLight) {
				if (myLight.range > 0.0f) {
					myLight.range = 0.0f;
					light_count -= 1;
					init_game.shelf_selected = 0;
				} else {
					if (light_count > 0) {
						
					} else {
						myLight.range = 1.6f;
						light_count += 1;		
						init_game.shelf_selected = 3;		
					}
				}
			}		
		} else if (myName == "shelf_4") {
			if (myLight) {
				if (myLight.range > 0.0f) {
					myLight.range = 0.0f;
					light_count -= 1;
					init_game.shelf_selected = 0;
				} else {
					if (light_count > 0) {
				
					} else {
						myLight.range = 1.6f;
						light_count += 1;		
						init_game.shelf_selected = 4;		
					}
				}
			}
		}
		
		if (light_count > 0) {
			if (myTag == "panel") {
				if (myName.Length > 0) {
					panelString = myName.Split (splitchar);
					panelID = panelString [1];
					shelf_item_name = init_game.getShelfItem (init_game.shelf_selected);
					//shelf_object = GameObject.Find (shelf_item_name).GetComponent<Sprite> ();
					active_sprite = shelf_sprites [init_game.shelf_selected - 1];			
					if (active_sprite) {
						if (init_game.isPlaying == false) {
							shimmer.transform.position = transform.position;
							shimmer.Play ();
							init_game.isConfirmed = false;
							init_game.isPlaying = true;
							if (panel_control.instObject) {
//								Destroy (panel_control.instObject.gameObject);			
							} else {
								panel_control.instObject = Instantiate (active_sprite, transform.position, Quaternion.identity);
							}
						} else {
							shimmer.transform.position = transform.position;
							if (panel_control.instObject) {
//								Destroy (panel_control.instObject.gameObject);
							}
							panel_control.instObject = Instantiate (active_sprite, transform.position, Quaternion.identity);
						}
					}
				}
			} 
		}		
	}		
	
	void OnMouseUp ()
	{
		/*if (isPlaying == true) {
			shimmer.Stop ();
			isPlaying = false;
		}*/
	}	
	
	void OnTriggerEnter2D (Collider2D other)
	{
		//Debug.Log (other.name + " - Trigger Enter");	
		//Debug.Log (this.name + " - Panel Name");
		hold_item.panel_name = other.name;
		hold_item.panel_tag = other.tag;
	}
	
	void OnTriggerExit2D (Collider2D other)
	{
		//Debug.Log (this.name + " - Trigger Exit");
		//hold_item.panel_name = "";
	}
	
	void OnTriggerStay2D (Collider2D other)
	{
		//Debug.Log ("Name: " + name + " - Tag: " + tag);
		hold_item.panel_name = other.name;
		hold_item.panel_tag = other.tag;
	}
}
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ball_controller : MonoBehaviour
{
		private Vector3 mousePosition;
		public float moveSpeed = 0.1f;
		public GameObject explosion;
		public AudioSource explode_sound;
		public AudioSource bounce_sound;
		public AudioSource powerup_sound;
		public float volume_level = 0.4f;
		public ParticleSystem Powerup_effect;
		public ParticleSystem wallbump_effect;
		private float player_health = 1.0f;
		public Slider healthBarSlider;  //reference for slider
		private bool isGameOver = false;
		public Text healthValue;
		//public Animation cdAnim;
		//public Text gameOverText;
		//public ParticleSystem ImpactTest;
		// Use this for initialization
		
		void Start ()
		{
//				Time.timeScale = 0.0f;
				//gameOverText.enabled = false;
				healthValue.text = "100%";
				
//				Time.timeScale = 1.0f;
				//cdAnim.animation.Play ("3");
				//if (!cdAnim.animation.IsPlaying ("3")) {
				//		countDown.text = "2";
				//cdAnim.animation.Play ("3");
				//}
//				countDown.text = "2";
//				cdAnim.animation.Play ("3");
				/*			while (cdAnim.animation.isPlaying) {
				
				}
				countDown.text = "2";
				cdAnim.animation.Play ();
				while (cdAnim.animation.isPlaying) {
			
				}
				countDown.text = "1";
				cdAnim.animation.Play ();
				while (cdAnim.animation.isPlaying) {
			
				}
		
				countDown.text = "GO !";
				cdAnim.Play ();
				while (cdAnim.isPlaying) {
			
				}
	*/	
				explode_sound.volume = volume_level;
				bounce_sound.volume = volume_level;
				powerup_sound.volume = volume_level;
				//myScore = GameObject.FindWithTag ("circuit_score");
				//myText = GetComponent<GUIText> ();
				//myText.text = "90%";
				//audio_controller.sounds = 1;
				setscore.scoreText = "90%";
		}
	
		// Update is called once per frame
		void Update ()
		{
				//if(!isGameOver) {
				if (Input.GetMouseButton (0)) {
						mousePosition = Input.mousePosition;
						mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);
						transform.position = Vector2.Lerp (transform.position, mousePosition, moveSpeed);
			
				}
				if (transform.position.y > 1.3f) {
						transform.position = new Vector2 (transform.position.x, 1.3f);
				}
				if (transform.position.y < -1.3f) {
						transform.position = new Vector2 (transform.position.x, -1.3f);
				}
				//}	
				//ImpactTest
		}
	
		void onMouseDrag ()
		{
						
		}
		
		void OnTriggerEnter2D (Collider2D other)
		{
				
				Debug.Log ("hit: ");
				//particleSystem.renderer.sortingLayerName = "Default";
				//Instantiate (ImpactTest, transform.position, transform.rotation);
				
		}
		
		void OnCollisionEnter2D (Collision2D coll)
		{
				Debug.Log ("collision");
				//if (coll.gameObject.name == "bomb") {
				//Destroy (coll.gameObject);
				//this.GetComponent<healthScript> ().health -= 1;
				//}
				if (coll.gameObject.tag == "wall" || coll.gameObject.tag == "obstacle") {
						bounce_sound.Play ();
						wallbump_effect.Play ();
												
						player_health -= 0.1f;
						healthBarSlider.value = player_health;
						healthValue.text = Mathf.Round (player_health * 100f).ToString () + "%";
						
						if (player_health <= 0.0f) {
								Instantiate (explosion, transform.position, transform.rotation);

								//explode_sound.Play ();
								healthValue.text = "0%";
								healthBarSlider.value = 0.0f;		
								Destroy (this.gameObject);
								//Time.timeScale = 0.0f;
								Game_Over_Control.playFlag = true;
								anim_control.playFlag = true;
								//Application.LoadLevel ("sampleearth");			
						}
				}
				if (coll.gameObject.tag == "powerup_life") {
						powerup_sound.Play ();			
						DestroyObject (coll.gameObject);
						Powerup_effect.Play ();
						player_health += 0.1f;
						
						if (player_health >= 1.0f) {
								player_health = 1.0f;
						}
			
						healthBarSlider.value = player_health;
						healthValue.text = Mathf.Round (player_health * 100f).ToString () + "%";
						
						//Instantiate (powerup, transform.position, transform.rotation);
				}
//				myGUI_Health.TextString = init_game.player_health.tostring;
				//myGUI_Health.ValueBar = init_game.player_health;
				//Instantiate (explosion, transform.position, transform.rotation);
				//explode_sound.Play ();
		}
	
		void Spawn ()
		{
				
				//DestroyObject (this.gameObject);
		}
		
		void OnCollisionEnter (Collision collision)
		{
				Debug.Log ("Hit Wall!");
		}
		
		public void start_maze ()
		{
				panel_drop.start_drop = true;
		}
	
}

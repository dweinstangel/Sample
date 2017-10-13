using UnityEngine;
using System.Collections;
using System;

public class CharacterScript : MonoBehaviour
{
	//this will need to be set to the 
	//health bar renderer you wish to use.
	public SpriteRenderer healthBar;
	public int maxHealth = 100;
	//max speed of character
	public float maxSpeed = 5.0f;
	
	//adjustment for rotation based on sprite starting orientation.
	public float facingAngleAdjustment = -90.0f;
	
	private Animator animator;
	private Transform cachedTransform;
	private Rigidbody2D cachedRigidBody2D;
	private int health = 100;
	private Action deathFunction = () => {};
	
	private Vector2 healthScale;
	void Awake()
	{
		this.SetDeathFunction( () => { } );
	}
	
	/// <summary>
	/// Initialization function that needs to interact 
	/// with other components or objects that must be 
	/// initialized prior to working with them.
	/// </summary>
	private void Start()
	{
		//cached animator
		this.animator = this.GetComponent<Animator>();
		
		//cached transform
		this.cachedTransform = this.GetComponent<Transform>();
		
		//cached rigidbody
		this.cachedRigidBody2D = this.GetComponent<Rigidbody2D>();
		
		//scale the healthbar should be.
//		healthScale = healthBar.transform.localScale;
	}
	
	
	public void Move(Vector2 movement)
	{
		if (null == movement || null == this.cachedRigidBody2D)
		{
			return;
		}
		//move the rigid body, which is part of the physics system
		//This ensures smooth movement.
		this.cachedRigidBody2D.velocity = new Vector2(movement.x * maxSpeed, movement.y * maxSpeed);
		
		//take the absolute value and add, because x or y 
		//may be negative and potentially cancel eachother out.
		float speed = Mathf.Abs(movement.x) + Mathf.Abs(movement.y);
		
		//set the speed variable in the animation component to ensure proper state.
		this.animator.SetFloat("Speed", speed);
		
		//convert the vector into a radian angle, 
		//convert to degrees and then adjust for the 
		//spider's starting orientation
		float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg + facingAngleAdjustment;
		
		//don't rotate if we don't need to.
		if (speed > 0.0f)
		{
			//rotate by angle around the z axis.
			this.cachedTransform.rotation = Quaternion.AngleAxis(angle, new Vector3(0, 0, 1));
		}
		
	}
	
	public void AdjustHealth(int amount)
	{
		//adjust current health by amount.
		this.health += amount;
		
		//make sure character can't surpass max health
		if(this.health > this.maxHealth)
		{
			this.health = maxHealth;
		}
		else if (this.health < 0)
		{
			//execute the death function
			this.deathFunction();
		}
		//update the health bar with new amount
		this.UpdateHealthBar();
	}
	
	/// <summary>
	/// returns the current health.
	/// </summary>
	/// <returns>current health amount.</returns>
	public int GetHealth()
	{
		return this.health;
	}
	
	public void SetDeathFunction(Action action)
	{
		this.deathFunction = action;
	}
	
	/// <summary>
	/// Updates the health bar length and color based on current health.
	/// </summary>
	private void UpdateHealthBar()
	{
		// Set the health bar color between Red and Green based on current health.
		healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - this.GetHealth() * 0.01f);
		
		// Set the scale of the health bar to be proportional to the player's health.
		healthBar.transform.localScale = new Vector3(healthScale.x * this.GetHealth() * 0.01f, 1, 1);
	}
	
}

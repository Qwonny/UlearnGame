using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Animator anim;
	public float moveSpeed;
	public float jumpHeight;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;

    void Start()
    {
		anim = GetComponent<Animator>(); 
    }
	void FixedUpdate()
	{
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}
    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown (KeyCode.UpArrow) && grounded)
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);	
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);			
		}
		anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
		if (GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(0.2f, 0.2f, 1f);
		else if (GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(-0.2f, 0.2f, 1f);
	}
}

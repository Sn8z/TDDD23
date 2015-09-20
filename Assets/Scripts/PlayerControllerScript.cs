using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour {

	//Speed and direction
	public float maxSpeed = 2;
	bool facingRight = true;

	//Grounded or not
	bool grounded = false;
	bool canDoubleJump = false;
	public Transform groundCheck1;
	public Transform groundCheck2;
	public Transform groundCheck3;
	float groundRadius = 0.02f;
	public LayerMask whatIsGround;
	public float jumpForce = 700f;

	//Animations
	Animator anim;
	
	Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		//Hämtar bara referenser 1 gång, GetComponent är väldigt långsam!!!
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//are we on ground?
		//grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		grounded = isGrounded ();
		anim.SetBool("Ground", grounded);

		//get user input
		float move = Input.GetAxis("Horizontal");

		anim.SetFloat("Speed", Mathf.Abs(move));

		rb2d.velocity = new Vector2 (move * maxSpeed, rb2d.velocity.y);
		
		if(move > 0 && !facingRight)
			Flip();
		else if(move < 0 && facingRight)
			Flip();
		
	}

	bool isGrounded(){
		if (Physics2D.OverlapCircle (groundCheck1.position, groundRadius, whatIsGround))
			return true;
		if (Physics2D.OverlapCircle (groundCheck2.position, groundRadius, whatIsGround))
			return true;
		if (Physics2D.OverlapCircle (groundCheck3.position, groundRadius, whatIsGround))
			return true;
		return false;
	}

	void Update(){
		//Jump
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (grounded) {	
				anim.SetBool ("Ground", false);
				rb2d.AddForce (new Vector2 (0, jumpForce));
				canDoubleJump = true;
			}
			else if (canDoubleJump){
				rb2d.velocity = new Vector2(0,0);
				rb2d.AddForce (new Vector2 (0, jumpForce));
				canDoubleJump = false;
			}
		}

	}

	void Flip() {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}

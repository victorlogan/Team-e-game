using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//Part 1
	public float moveSpeed;
	public float jumpHeight;

	//Part 2
	public Transform groundCheck; //point in space
	public float groundCheckRadius; //determine how big the CircleCollider2D you make?
	public LayerMask whatIsGround;
	private bool grounded;

	private bool doubleJumped;

	// Use this for initialization
	void Start () {
	
	}

	//for Physics stuff
	void FixedUpdate() {
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
	}

	// Update is called once per frame
	void Update () {

		if (grounded)
			doubleJumped = false;

		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
			Jump();
		}

		if (Input.GetKeyDown (KeyCode.Space) && !doubleJumped && !grounded) {
			Jump();
			doubleJumped = true;
		}

		if (Input.GetKey (KeyCode.D)) {
			GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

		if (Input.GetKey (KeyCode.A)) {
			GetComponent<Rigidbody2D>().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}


	}

	public void Jump() {
		GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jumpHeight);	
	}
}

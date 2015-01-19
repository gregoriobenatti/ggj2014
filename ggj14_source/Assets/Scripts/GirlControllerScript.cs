using UnityEngine;
using System.Collections;

public class GirlControllerScript : MonoBehaviour 
{
	public float maxSpeed = 5f;
	private bool facingRight = true;
	
	private Animator anim;
	
	private bool grounded = false;
	private bool groundedEnemy = false;
	public Transform groundCheck;
	private float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public LayerMask whatIsGroundEnemy;
	public float jumpForce = 300f;
	private bool doubleJump = false;
	
	void Start () 
	{
		anim = GetComponent<Animator>();
	}
	
	void FixedUpdate ()
	{
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool("ground", grounded);

		groundedEnemy = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGroundEnemy);
		anim.SetBool("groundEnemy", groundedEnemy);
		
		if(grounded)
		{
			doubleJump = false;
		}

		if(groundedEnemy)
		{
			transform.parent.gameObject.AddComponent<GameOverScript>();
		}
		
		anim.SetFloat("vSpeed", rigidbody2D.velocity.y);

		float move = Input.GetAxis("Horizontal");
		anim.SetFloat("speed", Mathf.Abs(move));
		rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
		
		if(move > 0 && !facingRight)
			Flip();
		else if(move < 0 && facingRight)
			Flip();
	}
	
	void Update()
	{
		if ((grounded || !doubleJump) && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)))
		{
			anim.SetBool("ground", false);
			rigidbody2D.AddForce(new Vector2(0, jumpForce));
			
			if(!doubleJump && !grounded)
			{
				doubleJump = true;
			}  
		}

		if (Input.GetKeyDown(KeyCode.W))
		{
			anim.SetInteger("playerSkin", 2);
		}
		if (Input.GetKeyDown(KeyCode.Q))
		{
			anim.SetInteger("playerSkin", 1);
		}
		if (Input.GetKeyDown(KeyCode.E))
		{
			anim.SetInteger("playerSkin", 3);
		}

	}
	
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

}





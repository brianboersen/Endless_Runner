using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
	public float speed;

	private Rigidbody rigidBody;
	private Vector3 movement = new Vector3();
	private float canJump = 0f;
	public Rigidbody rb;
    private bool moving;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
        moving = true;
	}

	void Awake()
	{
		rigidBody = GetComponent<Rigidbody> ();
	}

	void Update ()
	{
        if (moving)
        {
            float x = Input.GetAxis("Horizontal");
            movement = new Vector3(x, 0f, 0f);
        }
        
		if (Input.GetButtonDown ("Jump") && Time.time > canJump) 
		{
			rb.velocity = new Vector3 (0, 7, 0);
			canJump = Time.time + 1.4f;
		}
	}

	void FixedUpdate ()
	{
        rigidBody.MovePosition(transform.position + movement * speed * Time.deltaTime);
//        rigidBody.AddForce (movement.normalized * speed);
	}
}
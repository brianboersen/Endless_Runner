using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float speed;

    private Rigidbody rigidBody;
    private Vector3 movement = new Vector3();
    public Rigidbody rb;
    private bool moving;
    private bool canJump;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moving = true;
        canJump = false;

    }

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision other)
    {
        canJump = true;
    }

    void OnCollisionExit(Collision other)
    {
        canJump = false;
    }

    void FixedUpdate()
    {
        if (moving)
        {
            float x = Input.GetAxis("Horizontal");
            movement = new Vector3(x, 0f, 0f);
        }

        if (Input.GetButton("Jump") && canJump == true)
        {
            rb.velocity = new Vector3(0, 7, 0);
        }

        rigidBody.MovePosition(transform.position + movement * speed * Time.deltaTime);
    }
}

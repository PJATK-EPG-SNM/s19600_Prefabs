using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 500;
    public float jumpSpeed = 400;

    private Rigidbody2D rb;
    private float xDisplacement;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        xDisplacement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);

        if (Input.GetKeyDown("space") && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpSpeed));
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        isGrounded = true;
    }
}

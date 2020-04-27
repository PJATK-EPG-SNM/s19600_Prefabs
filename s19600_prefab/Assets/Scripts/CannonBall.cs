using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D rb;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * -1 * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.CompareTag("My Player"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}

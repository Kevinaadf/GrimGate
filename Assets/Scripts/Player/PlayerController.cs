using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpHeight;


    private Vector3 direction;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        
        direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);

        transform.position += direction * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

    }

    public void Jump()
    {
        rb.AddForce(new Vector2(0, jumpHeight));
    }

}

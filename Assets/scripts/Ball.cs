using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpspeed = 5;
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
     void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity += Vector2.up * jumpspeed;
        }
        var hor = Input.GetAxisRaw("Horizontal");
        rb.AddForce(new Vector2(hor, 0) * jumpspeed);

        var ver = Input.GetAxisRaw("Vertical");
        rb.AddForce(new Vector2(ver, 0) * jumpspeed);

    }
}
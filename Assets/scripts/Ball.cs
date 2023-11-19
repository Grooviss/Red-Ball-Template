using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpspeed = 5;
    bool isgrounded;
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
     void Update()
    {
        var hor = Input.GetAxisRaw("Horizontal");
        rb.AddForce(new Vector2(hor, 0));
        if(Input.GetButtonDown("Jump") && isgrounded)
        {
            rb.velocity += Vector2.up * jumpspeed;
        }

       

    }

    void OnCollisionExit2D(Collision2D other)
    {
        isgrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isgrounded = true;
        if (collision.collider.name.Contains("Spike"))
        {
            Invoke("Die", 1f);
        }
        print("hi");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.Win();
        
    }
    void Die()
    {
        GameManager.instance.hp--;
        SceneManager.LoadScene(GameManager.instance.currentLevel);

        if (GameManager.instance.hp == 0)
        {
            GameManager.instance.lose();
           
        }
        print("hi");
    }
}
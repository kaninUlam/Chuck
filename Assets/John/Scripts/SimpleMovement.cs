using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float jumpheight = 5;
    public float speed = 5;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rb.AddForce(Vector2.right * horizontalInput * speed );
        rb.AddForce(Vector2.up * verticalInput * jumpheight, ForceMode2D.Force);




    }
    
}

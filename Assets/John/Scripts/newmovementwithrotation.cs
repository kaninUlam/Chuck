using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newmovementwithrotation : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;

    public float jumpForce = 10f;
    public Transform feet;
    public LayerMask groundLayers;

    public Sprite running;
    public Sprite standing;
    float mx;

    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");
        if (Input.GetAxis("Horizontal") >= 0)
        {
            GetComponent<SpriteRenderer>().sprite = running;
        }
        if (Input.GetAxis("Horizontal") >= 0)
        {
            GetComponent<SpriteRenderer>().sprite = running;
        }

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);

        rb.velocity = movement;
        if (mx < 0)
        {
            
            this.gameObject.transform.eulerAngles = new Vector3(0, -180, 0);
        }
        if (mx > 0)
        {
            this.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = movement;

    }

    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }

        return false;
    }
}

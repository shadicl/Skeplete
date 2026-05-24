using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    public float jumpForce = 0.8f;

    public int sprintMultiplier = 2;
    public float staminaAmount = 1f;
    public float maxStamina = 1f;
    public float staminaDrain = 0.2f;

    public Rigidbody2D rb;
    float moveInput;
    public bool isGrounded;
    public bool isSprinting = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        // Sprint

        if (Input.GetKey(KeyCode.LeftShift) && staminaAmount > 0)
        {
            isSprinting = true;
        }
        else
        {
            if (isSprinting)
            {
                isSprinting = false;
            }
        }

        // Clamp stamina
        staminaAmount = Mathf.Clamp(staminaAmount, 0, maxStamina);
    }

    void FixedUpdate()
    {
       float speed = isSprinting ? moveSpeed * sprintMultiplier : moveSpeed;

       rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y);

       // Drain stamina

       if (isSprinting)
       {
            staminaAmount -= staminaDrain * Time.deltaTime;
       }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}

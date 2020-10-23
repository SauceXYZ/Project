using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=j111eKN8sJw
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private float moveInput;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;
    private float jumpDelayCounter = 0;
    public float jumpDelay;

    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    void Update()
    {
        bool oldIsGrounded = isGrounded;
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        if (isGrounded && (isGrounded != oldIsGrounded))
        {
            jumpDelayCounter = jumpDelay;
        }
        if (jumpDelayCounter > 0)
        {
            jumpDelayCounter -= Time.deltaTime;
            if (jumpDelayCounter < 0)
            {
                jumpDelayCounter = 0;
            }
        }

        if (moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if(moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (Input.GetButton("Jump"))
        {
            if (isGrounded && jumpDelayCounter == 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                isJumping = true;
                jumpTimeCounter = jumpTime;
            }

            if (isJumping)
            {
                if (jumpTimeCounter > 0)
                {
                    rb.velocity = Vector2.up * jumpForce;
                    jumpTimeCounter -= Time.deltaTime;
                }
                else
                {
                    isJumping = false;
                }
            }
        }
        else
        {
            isJumping = false;
        }

        animator.SetFloat("HorizontalSpeed", Math.Abs(rb.velocity.x));
        animator.SetBool("IsFalling", !isGrounded && rb.velocity.y < 0);
        animator.SetBool("IsJumping", isJumping);
    }
}

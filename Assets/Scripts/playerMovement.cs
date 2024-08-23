using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playerMovement : MonoBehaviour
{
    public float playerSpeed;
    public Rigidbody2D rigidBody;
    public Animator animator;

    Vector2 movement;

    void Start () { 
        playerSpeed = 0f;
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);

        if (Math.Abs(movement.x) > 0 || Math.Abs(movement.y) > 0){
            playerSpeed = 4f;
            animator.SetFloat("Speed", playerSpeed);
        }

        if (movement != Vector2.zero)
        {
            animator.SetFloat("lastHorizontal", movement.x);
            animator.SetFloat("lastVertical", movement.y);
        }

    }

    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + movement * playerSpeed * Time.fixedDeltaTime);
    }
}

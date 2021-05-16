using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runningMoveSpeed = 10.0f;

    float moveSpeed = 0.0f;
    bool jumping = false;
    bool crouch = false;

    void Start()
    {
        
    }

    void Update()
    {
        moveSpeed = Input.GetAxisRaw("Horizontal") * runningMoveSpeed;

        animator.SetFloat("Speed", Mathf.Abs(moveSpeed));

        if (Input.GetButtonDown("Jump")) 
        {
            jumping = true;
            animator.SetBool("IsJumping", true);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } 
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate() 
    {
        controller.Move(moveSpeed * Time.fixedDeltaTime, crouch, jumping);
        jumping = false;
    }
}

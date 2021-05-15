using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public Rigidbody2D rb;
    public CharacterController2D controller;

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

        if (Input.GetButtonDown("Jump")) 
        {
            jumping = true;
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

    void FixedUpdate() 
    {
        controller.Move(moveSpeed * Time.fixedDeltaTime, crouch, jumping);
        jumping = false;
    }
}

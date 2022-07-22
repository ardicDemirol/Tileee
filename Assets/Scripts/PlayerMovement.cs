using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] float runSpeed = 10f;
    Vector2 moveInput;
    Rigidbody2D myRigidbody;


    void Start()
    {
       myRigidbody = GetComponent<Rigidbody2D>();
            
    }

    void Update()
    {
        Run();
    }

    //void OnMove(InputValue value)
    //{
    //    moveInput = value.Get<Vector2>();
    //}

    void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.Get<Vector2>();
    }

    void Run()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerVelocity;
    }
}


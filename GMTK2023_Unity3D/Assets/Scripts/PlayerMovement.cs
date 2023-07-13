using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // input manager used
    InputManager inputManager;
    // rigidbody used
    Rigidbody playerRigidbody;

    // direction to move
    Vector3 moveDirection;
    // speeds to move and jump at
    [SerializeField] private float movementSpeed = 2;
    [SerializeField] private float jumpSpeed = 8;

    // calls on creation
    private void Awake()
    {
        // instantiate components
        inputManager = GetComponent<InputManager>();
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // assigning player movements
    public void HandleMovement(bool canJump)
    {
        // assign the x component (side, so horizontal input (a or d))
        moveDirection.z = -inputManager.movementInput * movementSpeed;
        
        // handle jumping
        if (canJump && inputManager.jumpInput)
        {
            moveDirection.y = jumpSpeed;
        }
        else
        {
            moveDirection.y = playerRigidbody.velocity.y;
        }

        // assign the movement velocity to rigidbody by multiplying direction by speed
        playerRigidbody.velocity = moveDirection;
    }
}

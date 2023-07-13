using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerManager : MonoBehaviour
{
    // objects
    InputManager inputManager;
    PlayerMovement playerMovement;

    private bool canJump = true;

    // on creation
    private void Awake()
    {
        // get components
        inputManager = GetComponent<InputManager>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    // every physics frame
    private void FixedUpdate()
    {
        // affects rigidbody so in fixed update
        playerMovement.HandleMovement(canJump);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "grass")
        {
            canJump = true;
        }

        if (collision.gameObject.tag == "arrow")
        {
            FindObjectOfType<GameManager>().score += 1;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "grass")
        {
            canJump = false;
        }
    }
}

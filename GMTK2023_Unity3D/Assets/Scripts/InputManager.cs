using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // can now use input system as a class
    PlayerControls playerControls;

    // movement input is a vector2
    public float movementInput;

    // action input
    public bool jumpInput = false;

    // when this script is enabled
    private void OnEnable()
    {
        // if there is no playerControls
        if (playerControls == null)
        {
            // make one
            playerControls = new PlayerControls();

            // move input
            playerControls.PlayerMovement.LeftRight.performed += (i) => movementInput = i.ReadValue<float>();

            // jump input
            playerControls.PlayerMovement.Jump.performed += (i) => jumpInput = true;
            playerControls.PlayerMovement.Jump.canceled += (i) => jumpInput = false;
        }

        // enable controls
        playerControls.Enable();
    }

    // when the script is disabled
    private void OnDisable()
    {
        // disable controls
        playerControls.Disable();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowAnimator : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void HandleAnimationStates(int animationState)
    {
        if (animationState == 0)
        {
            animator.Play("Rest", -1, 0f);
        }
        else if (animationState == 1)
        {
            animator.Play("Draw", -1, 0f);
        }
        else if (animationState == 2)
        {
            animator.Play("Shoot", -1, 0f);
        }
    }
}

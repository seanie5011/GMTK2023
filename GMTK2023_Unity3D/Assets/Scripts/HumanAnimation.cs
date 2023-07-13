using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanAnimation : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayShootAnimation()
    {
        animator.Play("Shoot", -1, 0f);
        transform.Rotate(new Vector3(0, -20.197f, 0));
    }
}

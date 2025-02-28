using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;
    
    // Start is called before the first frame update
    private void Start()
    {
        //Cache the animator component attached to CharacterArt
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        //running and idling
        if(Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("RunTrigger");

        }
        else
        {
            animator.SetTrigger("IdleTrigger");
        }

        //jump button
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("JumpTrigger");
        }

        //fall animation
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("FallTrigger");
        }

        //wall jumping
        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("WallJumpTrigger");
        }

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour {

    [SerializeField] private CharacterController2D controller;
    [SerializeField] private Animator animator;
    float currentDirection = 0.0f;
    bool isJumping = false;
    bool isCrouching = false;
	
	// Update is called once per frame
	void Update () {

        currentDirection = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(currentDirection));

        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            animator.SetBool("isJumping", true);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            isCrouching = true;
        }else if (Input.GetButtonUp("Crouch"))
        {
            isCrouching = false;
        }

	}

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("isCrouching", isCrouching);
    }

    //Move Character.
    void FixedUpdate()
    {
        controller.Move(currentDirection, isCrouching, isJumping);
        isJumping = false;
       
    }
}

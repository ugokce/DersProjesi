using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  MovementComponent: MonoBehaviour
{
    public float movementSpeed = 0.5f;

    private Animator characterAnimator;

    public CharacterController Controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        characterAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        Vector3 movementDirection = Vector3.zero;
        
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            characterAnimator.SetFloat("VelocityY", 0);
            movementSpeed = 0;
        }
        
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            characterAnimator.SetFloat("VelocityX", 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            movementSpeed = 5;
            characterAnimator.SetFloat("VelocityY", 5);
            movementDirection += transform.forward;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            movementSpeed = 5;
            characterAnimator.SetFloat("VelocityY", -5);
            movementDirection += -transform.forward;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            movementSpeed = 5;
            characterAnimator.SetFloat("VelocityX", 5);
            movementDirection += transform.right;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            movementSpeed = 5;
            characterAnimator.SetFloat("VelocityX", -5);
            movementDirection += -transform.right;
        }

        Controller.Move(movementDirection * movementSpeed * Time.deltaTime);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            characterAnimator.SetTrigger("Jump");
        }
    }
}

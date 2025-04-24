using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private CharacterController controller;
    private Transform thisTransform;
    private Vector3 movementVector = Vector3.zero;
    private Vector3 velocity;
    public float jumpForce = .01f;
    public float gravity = -30.81f;

    private void Start()
    {
        //Cache references to components
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    private void Update()
    {
        MoveCharacter();
        KeepCharacterOnXAxis();
        ApplyGravity();
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -.5f * gravity);
        }

    }

    private void MoveCharacter()
    {
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector *= (moveSpeed * Time.deltaTime);
        controller.Move(movementVector);
    }

    private void ApplyGravity()
    {
        if (!controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            velocity.y = 0.0f;
        }
        controller.Move(velocity * Time.deltaTime);
    }

    private void KeepCharacterOnXAxis()
    {
        var currentPosition = thisTransform.position;
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            currentPosition.z = 1f;
        }
        else
        {
            currentPosition.z = 0f;
        }
        
        thisTransform.position = currentPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectible")
        {
            Destroy(other.gameObject);
        }
    }
}

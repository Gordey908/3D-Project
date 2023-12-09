using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    private const float SPEED = 4f;
    private float MoveX, MoveY, MoveZ;

    [SerializeField]
    private CharacterController controller;
    private Vector3 movDir;

    void Start()
    {
        
    }

    void Update()
    {
        //MovingWithTransformPosition();
        //MovingWithTransformTranslate();
        //MovingWithVelocity();
        //MovingWithVelocity();
    }

    private void MovingWithTransformPosition()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.1f);
        }
    }
    private void MovingWithTransformTranslate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.fixedDeltaTime);
        }
    }
    private void MovingWithVelocity()
    {
        MoveX = Input.GetAxis("Horizontal");
        MoveZ = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(MoveX, MoveY, MoveZ);
    }
    private void MovingWithController()
    {
        MoveX = Input.GetAxis("Horizontal");
        MoveZ = Input.GetAxis("Vertical");

        if(controller.isGrounded)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                MoveY = 0.15f;
            }
            else
            {
                MoveY = 0f;
            }
        }
        else
        {
            MoveY -= 1f * Time.fixedDeltaTime;
        }
        movDir = new Vector3(MoveX * Time.fixedDeltaTime, MoveY, MoveZ * Time.fixedDeltaTime);
        controller.Move(movDir * SPEED);
    }
}

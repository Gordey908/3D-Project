using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private Animator animator;

    private float AngleY, dizZ, jumpforce = 6f, turnSpeed = 800f;
    private bool isGrounded;
    private Vector3 jumpDir;

    void FixedUpdate()
    {
        AngleY = Input.GetAxis("Mouse X") * Time.fixedDeltaTime * turnSpeed;
        dizZ = Input.GetAxis("Vertical");
        transform.Rotate(new Vector3(0f, AngleY, 0f));
    }
    private void Update()
    {
        if (isGrounded)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Move();
                Sprint();
                Dodge();
            }
            else
            {
                animator.SetTrigger("isLanged");
            }
        }
        else
        {
            MoveInAir();
        }
    }

    private void Jump()
    {

    }

    private void Move()
    {

    }
    private void Sprint()
    {

    }
    private void Dodge()
    {

    }
    private void MoveInAir()
    {

    }
}
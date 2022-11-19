using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float movementSpeed = 5f;
    public float jumpForce = 5f;
    public GameObject bulletClonetemplate;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("isJumping", true);
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
        else
        {
            animator.SetBool("isJumping", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("IsMoving", true);
            rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed); 
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            
            rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
        }


        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            
            rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed); 
        }
       

        if (Input.GetKey(KeyCode.Mouse0))
        {
            Instantiate(bulletClonetemplate, transform.position,transform.rotation);
        }
      
    }
}

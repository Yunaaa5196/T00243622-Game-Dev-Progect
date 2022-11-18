using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]float movementSpeed = 5f;
    [SerializeField] float jumpForce = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }

        //if (Input.GetKey("up"))
        //{
          // rb.velocity = new Vector3(0, 0, 5f);
        //}

       // if (Input.GetKey("right"))
        //{
          // rb.velocity = new Vector3(5f, 0, 0);
       // }

        //if (Input.GetKey("down"))
       // {
          //  rb.velocity = new Vector3(0, 0, -5f);
       // }

        //if (Input.GetKey("left"))
        //{
           // rb.velocity = new Vector3(-5f, 0, 0);
        //}

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

   public CharacterController controller;
   public float speed = 12f;
   public float gravity = -9.81f;
   public float jumpheight = 0f;



   public Transform groundcheck;
   public float grounddistance = 0.4f;
   public LayerMask groundmask;
   Vector3 velocity;
   public bool isGrounded;


    void Update()
    {
        isGrounded = Physics.CheckSphere(groundcheck.position, grounddistance, groundmask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        
        
        {controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpheight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        }



        //if(Input.GetButtonDown("Jump") && isGrounded)
        //{
        //    velocity.y = Mathf.Sqrt(-2f * gravity);
        //}

        
        controller.Move(velocity * Time.deltaTime);
        


        
    }
}

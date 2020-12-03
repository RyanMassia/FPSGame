using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;//character controller on player 
    public Transform groundCheck;//groundcheck object on player;

    public float speed = 12f; // players speed 
    public float gravity = -9.81f; // gravity 
    public float groundDistance = 0.4f;//distance from the ground 

    Vector3 velocity; // will track our velocity speed 

    bool isGrounded; // checks to make sure player is grounded 

    public LayerMask groundMask;//
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Grounded();
        Movement();
    }

    void Movement()
    {
        float x = Input.GetAxis("Horizontal"); // gets inpit for horizontal axis
        float z = Input.GetAxis("Vertical"); // gets inpit for vertical axis

        Vector3 move = transform.right * x + transform.forward * z; // takes the transform of the player and times it by the x input, and takes the forward and times it by the veritcal axis

        controller.Move(move * speed * Time.deltaTime); //takes our movement and increases it by speed variable when the frame is updated; 

        velocity.y += gravity * Time.deltaTime; // will increase the y vector velocity by the gravity  

        controller.Move(velocity * Time.deltaTime);
    }

    void Grounded()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); // creates a sphere at groundcheck location to see if the postion is touching the ground mask

        if (isGrounded && velocity.y < 0) // if the player is touching the ground and the velocity.y is less then zero set velocity to -2 to make sure on the ground;
        {
            velocity.y = -2f;
        }
    }
}

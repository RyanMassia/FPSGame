using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // gets inpit for horizontal axis
        float z = Input.GetAxis("Vertical"); // gets inpit for vertical axis

        Vector3 move = transform.right * x + transform.forward * z; // takes the transform of the player and times it by the x input, and takes the forward and times it by the veritcal axis

        controller.Move(move * speed * Time.deltaTime); //takes our movement and increases it by speed variable when the frame is updated; 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform PlayerBody; // public player model
    public float mouseSens = 100f; // mouse sensitivit
    float xRotation = 0f;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime; // gets x axis input and mutliplies by mouse Sesnivity and time 
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime; // gets y axis input and mutliplies by mouse Sesnivity and time 
        xRotation -= mouseY;

        PlayerBody.Rotate(Vector3.up, mouseX);//plater will rotate on the x axis 
    }
}

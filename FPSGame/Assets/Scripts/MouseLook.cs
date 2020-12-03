using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform PlayerBody; // public player model
    public float mouseSens = 100f; // mouse sensitivit
    float xRotation = 0f; // speed of the rotation on the x axis


    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime; // gets x axis input and mutliplies by mouse Sesnivity and time 
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime; // gets y axis input and mutliplies by mouse Sesnivity and time 

        xRotation -= mouseY; // decreases the x rotation by the mouse why movement 
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // locks the xrotation  between -90 and 90 so the player cant look behind self

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // rotates on the x axis without affecting y or z axis
        PlayerBody.Rotate(Vector3.up * mouseX);//plater will rotate on the y axis 
    }
}

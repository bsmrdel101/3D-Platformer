using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    [Header("Camera Controls")]
    [SerializeField] private float sensitivity;
    [SerializeField] private Transform orientation; 
    private float xRot, yRot;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Get player input (camera movement)
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitivity;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivity;

        // Get rotation values
        yRot += mouseX;
        xRot -= mouseY; 

        // Prevent camera from looking vertically more than 90 deg
        xRot = Mathf.Clamp(xRot, -90, 90);

        // Rotate cam and orientation
        transform.rotation = Quaternion.Euler(xRot, yRot, 0);
        orientation.rotation = Quaternion.Euler(0, yRot, 0);    
    }
}
 
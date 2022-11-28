using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    [Header("Player Stats")]
    public float moveSpeed; //Movement speed in units per second
    public float jumpForce; //Force applied to the y axis to make the player jump
    [Header("Camera Info")]
    public float lookSensitivity; //mouse look sensitivity
    public float maxLookX; //Lowest point we can look down
    public float minLookX; //highest point we can look up
    public float rotX; //Current x rotation of the camera
    [Header("Private Variables")]
    private Camera camera; //Reference the main camera
    private Rigidbody rb; //Reference the ridgedbody component

    void Awake()
    {
        //Get components
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed; //Move left and right(Input)
        float z = Input.GetAxis("Vertical") * moveSpeed; //Move Forward and Back(Player)
        
        rb.velocity = new Vector3(x, rb.velocity.y, z); //Applys veclodity on x and z axes. It makes the player move
    }
    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;
    }
}

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
        Cursor.lockState = CursorLockMode.Locked;  //Get components
        
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
        CameraLook();

        if(Input.GetButtonDown("Jump"))
            PlayerJump();
    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed; //Move left and right(Input)
        float z = Input.GetAxis("Vertical") * moveSpeed; //Move Forward and Back(Player)
        
        Vector3 dir = transform.right * x + transform.forward * z;
        dir.y = rb.velocity.y;

        rb.velocity = dir; //Applys veclodity on x and z axes. It makes the player move
    }
    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;
    
    
    rotX = Mathf.Clamp(rotX, minLookX, maxLookX);

    camera.transform.localRotation = Quaternion.Euler(-rotX, 0 ,0);
    transform.eulerAngles += Vector3.up * y;
    }
    void PlayerJump()
    {
    Ray ray = new Ray(transform.position, Vector3.down);

    if(Physics.Raycast(ray, 1.1f))
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    public void GiveHealth(int amount)
    {

    }

    public void GiveAmmo(int amount)
    {
        
    }

}

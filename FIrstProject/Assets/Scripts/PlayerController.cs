using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
//Set speed
    public float speed;
    // rotation speed
    public float rotSpeed;
    //horizontal input
    public float hInput;
    //vertical input
    public float vInput;
   


    // Update is called once per frame
    void Update()
    {
        //collect input values from keyboard
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        //move character
        transform.Rotate(Vector3.up, rotSpeed * hInput * Time.deltaTime); // left and right
        
        transform.Translate(Vector3.forward * speed * vInput * Time.deltaTime); //Forward
    }
}

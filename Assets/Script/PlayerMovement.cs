using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private float speed = 10f;
    
    public float rotationSpeed = 100f; // added rotation speed variable

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // get input from left and right arrow keys
        float verticalInput = Input.GetAxis("Vertical"); // get input from up and down arrow keys

        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime); // move car forward/backward
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime); // rotate car left/right
    }
}

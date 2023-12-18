using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed as needed

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get input values for horizontal and vertical axes
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Move the object based on the input
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}

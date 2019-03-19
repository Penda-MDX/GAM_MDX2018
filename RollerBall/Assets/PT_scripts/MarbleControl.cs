using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleControl : MonoBehaviour {

    public Rigidbody currentMarble;
    public Vector3 maxVelocityMagnitude;
    public float movementSpeed;
    public float movingDrag;
    public float groundDrag;
    public bool relativeForce;

    private Vector3 moveDirection;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (currentMarble.velocity.magnitude > maxVelocityMagnitude.magnitude)
        {
            currentMarble.velocity = currentMarble.velocity * 0.95f;
        }

        moveDirection.x = Input.GetAxis("Horizontal");
        moveDirection.y = 0;
        moveDirection.z = Input.GetAxis("Vertical");
        moveDirection = moveDirection * movementSpeed * Time.deltaTime;
        if (moveDirection != Vector3.zero)
        {

            if (relativeForce)
            {
                currentMarble.AddRelativeForce(moveDirection);
            }
            else
            {
                currentMarble.AddForce(moveDirection);
            }

            currentMarble.drag = movingDrag;
        }
        else
        {
            currentMarble.drag = groundDrag;
        }
    }
}

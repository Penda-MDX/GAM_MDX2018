using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_jellyfish_rotate_push : MonoBehaviour {

    public float fl_MovementSpeed = 6f;
    public float maxVelocity = 5f;
    public float fl_turnRate = 1.0f;

    public float noInputDrag = 2.0f;
    public float inputDrag = 0.0f;

    private Vector3 V3_move_direction = Vector3.zero;
    private Rigidbody characterRB;
    //public List<Rigidbody> childRigidbodies;
    private Rigidbody[] childRigidbodies;

    // Use this for initialization
    void Start()
    {
        characterRB = GetComponent<Rigidbody>();

        Rigidbody[] allChildren = GetComponentsInChildren<Rigidbody>();
        childRigidbodies = new Rigidbody[allChildren.Length];
        //foreach (Rigidbody child in allChildren) {
        for (int i = 0; i < allChildren.Length; i++)
        {
            // do whatever with child transform here
            childRigidbodies[i] = allChildren[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        V3_move_direction = Vector3.zero;
        float xRotation = Input.GetAxis("Vertical");
        float yRotation = Input.GetAxis("Horizontal");
        if (xRotation!=0 || yRotation!=0)
        {
            transform.Rotate(xRotation * fl_turnRate, yRotation * fl_turnRate, 0);
            characterRB.drag = inputDrag;
            V3_move_direction = transform.forward;
        }
        //V3_move_direction.x = Input.GetAxis("Horizontal");
        //V3_move_direction.y = 0.0f;
        //V3_move_direction.z = Input.GetAxis("Vertical");

        if (Input.GetButton("Jump"))
        {
            V3_move_direction = transform.forward * fl_MovementSpeed * Time.deltaTime;
        }
        
        if (V3_move_direction != Vector3.zero)
        {
           
          if (characterRB.velocity.magnitude < maxVelocity)
           {
                characterRB.AddForce(V3_move_direction);
                characterRB.drag = inputDrag;
                //playing with wall running
                //characterRB.useGravity = false;
                foreach (Rigidbody childRB in childRigidbodies)
                {
                    childRB.drag = inputDrag;
                }
          }

        }
        else
        {
            characterRB.drag = noInputDrag;
            foreach (Rigidbody childRB in childRigidbodies)
            {
                childRB.drag = noInputDrag;
            }
        }
    }
}

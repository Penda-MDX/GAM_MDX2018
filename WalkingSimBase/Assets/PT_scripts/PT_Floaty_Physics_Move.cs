using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Floaty_Physics_Move : MonoBehaviour {
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
	void Start () {
		characterRB = GetComponent<Rigidbody> ();

		Rigidbody[] allChildren = GetComponentsInChildren<Rigidbody>();
		childRigidbodies = new Rigidbody[allChildren.Length];
		//foreach (Rigidbody child in allChildren) {
		for(int i=0; i<allChildren.Length;i++){
			// do whatever with child transform here
			childRigidbodies[i] = allChildren[i];
		}
	}
	
	// Update is called once per frame
	void Update () {


		V3_move_direction.x = Input.GetAxis("Horizontal");
		V3_move_direction.y = 0.0f;
		V3_move_direction.z = Input.GetAxis("Vertical");
		V3_move_direction = V3_move_direction * fl_MovementSpeed * Time.deltaTime;
		if (V3_move_direction!=Vector3.zero)
		{
			
			characterRB.AddRelativeForce(V3_move_direction);
			characterRB.drag = inputDrag;
			//playing with wall running
			//characterRB.useGravity = false;
			foreach (Rigidbody childRB in childRigidbodies) {
				childRB.drag = inputDrag + 0.2f;
			}
		}
		else
		{
			characterRB.drag = noInputDrag;
			foreach (Rigidbody childRB in childRigidbodies) {
				childRB.drag = noInputDrag;
			}
		}
	}
}

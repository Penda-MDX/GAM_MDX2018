using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsManager : MonoBehaviour {

    public Rigidbody[] thingsToBePushed;
    public Vector3[] forcePush;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("k"))
        {
            foreach(Rigidbody thing in thingsToBePushed)
            {
                PushSomething(thing, forcePush[0]);
            }
        }
	}

    public void PushSomething(Rigidbody thingy, Vector3 forceDirection)
    {
        thingy.AddForce(forceDirection);
    }
}

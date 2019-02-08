using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanTrigger : MonoBehaviour {

    public LinkedNodes thisNode;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        thisNode.BeginPan();
    }

    private void OnTriggerExit(Collider other)
    {
        thisNode.EndPan();
    }
}

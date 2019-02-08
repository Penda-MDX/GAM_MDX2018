using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowLinkedNodes : MonoBehaviour {

    public LinkedNodes startNode;

    private Vector3 leftTarget;
    private Vector3 rightTarget;

	// Use this for initialization
	void Start ()
    {
        SetBounds();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void SetBounds()
    {

    }
}

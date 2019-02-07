using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPath : MonoBehaviour {

    public GameObject[] pathChunks;
    public GameObject thingToLookAt;

    public float cameraMoveSpeed = 3f;

    private GameObject[] chunkNodesArray;
    private GameObject currentNode;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//use nodes as constraints - x, y,and z?
        //follow thing to look at
        //look at the thing even when you cannot move
        
        //when you have reached the exit trigger load the next set of nodes
	}
}

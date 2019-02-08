using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPath : MonoBehaviour {

    public GameObject[] pathChunks;
    public GameObject thingToLookAt;
    public CameraPathChunk startChunk;
    private CameraPathChunk currentChunk;

    public float cameraMoveSpeed = 3f;

    private GameObject[] chunkNodesArray;
    private GameObject currentNodeLeft;
    private GameObject currentNodeRight;

    private bool onTrack;

    // Use this for initialization
    void Start () {
        if (startChunk != null)
        {
            onTrack = true;
            currentChunk = startChunk;
            currentNodes();
        }
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void currentNodes()
    {

    }

    public void chunkChange(CameraPathChunk newChunk)
    {

    }
}

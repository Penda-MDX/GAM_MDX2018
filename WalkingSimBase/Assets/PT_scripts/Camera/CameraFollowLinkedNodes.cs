using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowLinkedNodes : MonoBehaviour {

    public LinkedNodes startNode;
    public GameObject thingToFollow;
    public bool pointAt;
    private Vector3 leftTarget;
    private Vector3 rightTarget;
    private float distanceOnXAxis;
    private float distanceOnYAxis;
    private float distanceOnZAxis;

    private Vector3 neCameraPosition;

	// Use this for initialization
	void Start ()
    {
        FindTheThing();
        SetOffset();
        SetBounds();
	}
	
	// Update is called once per frame
	void Update ()
    {
        // print(go_thingToBeFollowed.transform.position.x);
        neCameraPosition.x = thingToFollow.transform.position.x + distanceOnXAxis;
        neCameraPosition.y = thingToFollow.transform.position.y + distanceOnYAxis;
        neCameraPosition.z = thingToFollow.transform.position.z + distanceOnZAxis;
        //
        if (neCameraPosition.x != transform.position.x || neCameraPosition.y != transform.position.y)
        {
            transform.position = neCameraPosition;
        }
        // should we rotate the camera to point at the thing we are following?
        if (pointAt)
        {
            transform.LookAt(thingToFollow.transform);
        }
    }

    void FindTheThing()
    {
        //if a thing to be followed by the camera has not been defined in the editor then 
        if (thingToFollow == null)
        {
            //Try getting all the objects with the Player Tag and pick the first one
            GameObject[] _List_Of_GameObjects = GameObject.FindGameObjectsWithTag("Player");
            thingToFollow = _List_Of_GameObjects[0];
        }
        //if there is still no object what do we do?
    }
    void SetOffset()
    {
        distanceOnXAxis = transform.position.x - thingToFollow.transform.position.x;
        distanceOnYAxis = transform.position.y - thingToFollow.transform.position.y;
        distanceOnZAxis = transform.position.z - thingToFollow.transform.position.z;
    }
    void SetBounds()
    {

    }
}

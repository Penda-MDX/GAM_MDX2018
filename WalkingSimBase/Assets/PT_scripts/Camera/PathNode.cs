using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Node00", menuName = "Path Node", order = 2)]
public class PathNode : ScriptableObject {

    public GameObject startTrigger;
    public GameObject endTrigger;
    public GameObject[] panTrigger;
    public Vector3[] waypoints;

    public Camera currentCamera;

	// Use this for initialization
	void OnEnable () {
		
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_BloodLockManager : MonoBehaviour {

    public int int_numberOfKillsRequired = 6;
    public bool bl_infinite = false;
    public float fl_timeBetweenWaves = 1f;
    public GameObject go_spawnee;
    public Vector3[] spawnPositions;

    private float fl_nextTime;
    private int int_countSoFar = 0;
    private int int_killedSoFar = 0; 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

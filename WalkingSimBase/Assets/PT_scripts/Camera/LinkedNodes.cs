using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedNodes : MonoBehaviour {

    public LinkedNodes previousNode;
    public LinkedNodes nextNode;

    public GameObject camPositionGO;
    public bool jumpOnPanEnd;
    public bool panningNow;
    
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void BeginPan()
    {
        panningNow = true;
    }

    public void EndPan()
    {
        panningNow = false;
    }
}

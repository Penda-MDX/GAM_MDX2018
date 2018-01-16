using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorButtonScript : MonoBehaviour {
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("e"))
		{
			if (anim.GetBool ("open")) {
				print ("Close the door");
				anim.SetBool ("open", false);
			} else {
				print ("Open the door");
				anim.SetBool ("open", true);
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchOnTrigger : MonoBehaviour {

	//3D trigger collider activated when RigidBody 
	//or Character Controller enters the collider
	void OnTriggerEnter (Collider other) {
		print ("Trigger box entered");
		SceneManager.LoadScene (0);
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchOnButton : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space"))
		{
			print("space key was pressed");
			// Load the next scene number 1 (this is number 0 scene)
			SceneManager.LoadScene(1);
		}
	}
}

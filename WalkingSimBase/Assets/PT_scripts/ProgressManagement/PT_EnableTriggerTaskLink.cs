using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_EnableTriggerTaskLink : MonoBehaviour {
    public bool bl_enable;
    public GameObject objectToActivate;
    public int RequiredProgressNumber;

    private PT_TaskManager levelTaskManager;

	// Use this for initialization
	void Start () {
        levelTaskManager = GameObject.Find("TaskManager").GetComponent<PT_TaskManager>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (levelTaskManager.ProgressNumber >= RequiredProgressNumber)
            {
                if (bl_enable)
                {
                    objectToActivate.SetActive(true);
                }
                else
                {
                    objectToActivate.SetActive(false);
                }
            }
        }
    }
}

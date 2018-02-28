using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Event_Trigger : MonoBehaviour {

    public int EventNumber;
    private PT_TaskManager CurrentTaskManager;

    private void OnEnable()
    {
        CurrentTaskManager = GameObject.Find("TaskManager").GetComponent<PT_TaskManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CurrentTaskManager.TaskCompleted(EventNumber);

        }
    }
}

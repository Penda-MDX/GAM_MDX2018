using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Event_Trigger : MonoBehaviour {

    public int EventNumber;
    public PT_TaskManager CurrentTaskManager;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CurrentTaskManager.TaskCompleted();

        }
    }
}

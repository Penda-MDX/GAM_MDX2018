using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_TaskManager : MonoBehaviour {

    public PT_Event[] Tasks;
    public int ProgressNumber;
    public GameObject eventTrigger;
    private int LastProgressNumber;
    private GameObject currentTarget;

	// Use this for initialization
	void Start () {
        //setup first event
        GenerateNewTask(0);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TaskCompleted(int CompleteTask)
    {
        print("Completed " + CompleteTask.ToString());
        OnSucceedEvent();
    }

    private void GenerateNewTask(int TaskIndex)
    {
        print("New Index " + TaskIndex.ToString());
        LastProgressNumber = ProgressNumber;
        currentTarget = Instantiate(eventTrigger, Tasks[TaskIndex].Location, Quaternion.identity);
        currentTarget.GetComponent<PT_Event_Trigger>().EventNumber = TaskIndex;
        ProgressNumber = TaskIndex;
        OnStartEvent();

    }

    public void OnStartEvent()
    {

    }

    public void OnSucceedEvent()
    {
        Destroy(currentTarget);
        GenerateNewTask(Tasks[ProgressNumber].SuccessNextProgress);
    }

    public void OnFailEvent()
    {
        GenerateNewTask(Tasks[ProgressNumber].FailNextProgress);
    }

    public void CheckEventState()
    {

    }
}

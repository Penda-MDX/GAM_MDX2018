using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_TaskManager : MonoBehaviour {

    public PT_Event[] Tasks;
    public int ProgressNumber;
    public GameObject eventTrigger;
    private int LastProgressNumber;

	// Use this for initialization
	void Start () {
        //setup first event
        GenerateNewTask(0);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TaskCompleted()
    {
        OnSucceedEvent();
    }

    private void GenerateNewTask(int TaskIndex)
    {
        LastProgressNumber = ProgressNumber;
        Instantiate(eventTrigger, Tasks[TaskIndex].Location, Quaternion.identity);

        OnStartEvent();

    }

    public void OnStartEvent()
    {

    }

    public void OnSucceedEvent()
    {
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

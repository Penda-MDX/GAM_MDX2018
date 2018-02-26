using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Event00", menuName = "Event Data", order = 1)]
public class PT_Event : ScriptableObject
{

    public Vector3 Location;
    public string ActivityType;
    public bool isCounter;
    public int Count;
    public float TimeToComplete;
    public bool hasStarted;
    public int SuccessNextProgress;
    public int FailNextProgress;

    public GameObject TargetObject;
    public Vector3[] SpawnPoints;
    public GameObject SpawnedObject;
    public bool DestroyObjectsOnCompletion;

    private void OnEnable()
    {
        //initialize

    }

}

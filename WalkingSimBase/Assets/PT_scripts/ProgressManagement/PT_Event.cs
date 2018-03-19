using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Event00", menuName = "Event Data", order = 1)]
public class PT_Event : ScriptableObject
{

    public Vector3 Location;
    public string ActivityType;
    public string Description;
    public string QuestName;
    public int SuccessNextProgress;
    public int FailNextProgress;

    public GameObject TargetObject;
    public GameObject SpawnedObject;

    private void OnEnable()
    {
        //initialize
        if (TargetObject != null)
        {
            if(Location == Vector3.zero)
            {
                Location = TargetObject.transform.position;
            }
        }

    }

}

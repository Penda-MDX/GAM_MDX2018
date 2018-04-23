using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_MessageTrigger : MonoBehaviour {

    [SerializeField] private PT_BasicMessage messageHandler;
    private bool interactionActive;
    
    //public int EventNumber;
    //private PT_TaskManager CurrentTaskManager;

    private void OnEnable()
    {
      //CurrentTaskManager = GameObject.Find("TaskManager").GetComponent<PT_TaskManager>();
    }

    // Update is called once per frame
    void Update () {
		if(interactionActive && Input.GetKeyUp("f"))
        {
            //CurrentTaskManager.TaskCompleted(EventNumber);
            messageHandler.CloseMessage();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            interactionActive = true;
            messageHandler.ShowMessage("Press the button? Press F to continue the quest.", 3.0f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            interactionActive = false;
        }
    }
}

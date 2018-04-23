using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PT_BasicMessage : MonoBehaviour {

    [SerializeField] private GameObject MessageCanvas;
    [SerializeField] private string MessageText;
    [SerializeField] private Text OnScreenText;
    private float timeOut;

	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (Input.GetKey("f"))
        {
            ShowMessage("The quick brown fox jumps over the lazy dog!", 3.0f);
        }
        */

        HideMessage();
	}

    public void ShowMessage(string message, float timeOnScreen)
    {
        OnScreenText.text = message;
        timeOut = Time.time + timeOnScreen;
        MessageCanvas.SetActive(true);
    }
    public void CloseMessage()
    {
        MessageCanvas.SetActive(false);
    }
    void HideMessage()
    {
        //if the time out is now less than the current time
        if (timeOut <= Time.time)
        {
            MessageCanvas.SetActive(false);
        }
    }

}

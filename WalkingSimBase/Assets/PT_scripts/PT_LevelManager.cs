using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;


public class PT_LevelManager : MonoBehaviour {

    public Transform lastGoodCheckpoint;

    public Canvas infoBar;
    public Canvas messageBox;

    public Text messageTextonScreen;
    public Text statusText;
    public float timeOnScreen = 2.5f;

    public string LevelName;
    public bool includetimerCount;

    private float timeComplete = 0;

    private int hours;
    private int minutes;
    private int seconds;

    private bool timerRunning;
    private float timerStart;
    private int timerHours;
    private int timerMinutes;
    private int timerSeconds;

    private string date;
    private string statusMessage;




    // Use this for initialization
    void Start () {
        timerHours = 0;
        timerMinutes = 0;
        timerSeconds = 0;
        timerRunning = false;

    }
	
	// Update is called once per frame
	void Update () {
        if (timeComplete < Time.time)
        {
            if (messageTextonScreen != null)
            {
                messageBox.gameObject.SetActive(false);
            }
        }
        //timer test with key press
        if (Input.GetKeyUp("l"))
        {
            //print("l pressed");
            if (timerRunning)
            {
                EndTimer();
            }
            else
            {
                StartTimer();
            }
        }
        ComposeStatus();

    }

    public void ShowMessage(string currentMessage)
    {
        if (messageTextonScreen != null)
        {
            messageTextonScreen.text = currentMessage;
            messageBox.gameObject.SetActive(true);
            timeComplete = Time.time + timeOnScreen;
        }
    }


    public void ComposeStatus()
    {
        var culture = new CultureInfo("en-GB");
        date = System.DateTime.Now.ToString(culture);
        float timeSoFar = 0; 

        if (timerRunning)
        {
            timeSoFar = Time.time - timerStart;
            //print("Timer " + timeSoFar);
            timerHours = Mathf.FloorToInt(timeSoFar/3600f);
            timerMinutes = Mathf.FloorToInt((timeSoFar%3600f)/60);
            timerSeconds = Mathf.FloorToInt((timeSoFar % 3600f) % 60);
        }
        string timer = timerHours.ToString().PadLeft(2,'0') + ":" + timerMinutes.ToString().PadLeft(2, '0') + ":" + timerSeconds.ToString().PadLeft(2, '0') + " ";
        string tween = "";
        if (includetimerCount)
        {
            statusText.text = timer.PadRight(30) + timeSoFar.ToString().PadRight(35) + LevelName.PadRight(60) + date;
        }
        else
        {
            statusText.text = timer.PadRight(30) + tween.ToString().PadRight(35) + LevelName.PadRight(60) + date;
        }
        

    }

    public void StartTimer()
    {
        timerStart = Time.time;
        timerRunning = true;
    }

    public void EndTimer()
    {
        timerHours = 0;
        timerMinutes = 0;
        timerSeconds = 0;
        timerRunning = false;
    }
}

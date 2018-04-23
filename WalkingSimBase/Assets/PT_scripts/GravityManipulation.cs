using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class GravityManipulation : MonoBehaviour
{

    public GameObject GravOn;
    public GameObject GravOff;
    public bool GravChanged = false;
    public float cooldown = 0.0f;

    private FirstPersonController FPSController;

    // Use this for initialization
    void Start()
    {
        FPSController = GetComponent<FirstPersonController>();
    }
    // Update is called once per frame
    void Update()
    {
        ChangeGravity();

        cooldown -= Time.deltaTime;
        if (cooldown <= 0.0f)
        {
            cooldown = 0.0f;
        }
    }

    void ChangeGravity()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            // Gravity change is on
            if (GravChanged == true && cooldown <= 0.0f)
            {
                cooldown = 2.0f;
                //FPSController.m_StickToGroundForce = 10.0f;
                //FPSController.m_JumpSpeed = 10.0f;
                //FPSController.m_GravityMultiplier = 2;
                //GravOn.SetActive(false);
                //GravOff.SetActive(true);
                GravChanged = false;
            }
            // Gravity change is off
            else if (GravChanged == false && cooldown <= 0.0f)
            {
                cooldown = 2.0f;
                //FPSController.m_StickToGroundForce = -10.0f;
                //FPSController.m_JumpSpeed = -10.0f;
                //FPSController.m_GravityMultiplier = -2.0f;
                //GravOn.SetActive(true);
                //GravOff.SetActive(false);
                GravChanged = true;
            }
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_PickUpWithDistanceCheck : MonoBehaviour {


    [SerializeField] private float dropDistance = 3.0f;
    [SerializeField] private bool turnOffPhysics = false;
    [SerializeField] private GameObject indicatorCircle;

    [SerializeField] private Material availablePickUpColour;
    [SerializeField] private Material isCarryingColour;

    private bool canPickUp = false;
    private GameObject movableObject;
    private GameObject carriedObject;
    
    private bool carryingObject = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("e"))
        {
            if (carryingObject)
            {
                DropCurrent();
            }
            else
            {
                PickUpCurrent();
            }
        }

        if (carryingObject)
        {
            if (Vector3.Distance(gameObject.transform.position, carriedObject.transform.position) > dropDistance)
            {
                DropCurrent();
            }
        }
    }


    public void PickUpCurrent()
    {
        if (canPickUp)
        {
            indicatorCircle.GetComponent<Renderer>().material = isCarryingColour;
            carryingObject = true;
            movableObject.transform.SetParent(gameObject.transform);
            carriedObject = movableObject;

            if (turnOffPhysics)
            {
                carriedObject.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    }

    public void DropCurrent()
    {
        carryingObject = false;
        carriedObject.transform.SetParent(null);
        indicatorCircle.GetComponent<Renderer>().material = availablePickUpColour;

        if (turnOffPhysics)
        {
            carriedObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Movable")
        {
            canPickUp = true;
            movableObject = other.gameObject;
            indicatorCircle.SetActive(true);
            indicatorCircle.GetComponent<Renderer>().material = availablePickUpColour;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Movable")
        {
            canPickUp = false;
            movableObject = null;
            indicatorCircle.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum proccessMode { waitForActor, waitForOrders, Processing};

public class BattleManager : MonoBehaviour {
    

    public List<EntityStats> participantsInitiative;
    public List<ActionOrder> ordersThisTurn;

    public proccessMode currentMode;

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Spawner : NetworkBehaviour {

    public GameObject ballPrefab;
    public GameObject thisball;
    public Transform spawnlocation;

    public int counter;
	
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (counter < 3 && Variables.ballTrigger)
        {
            thisball = (GameObject)Instantiate(ballPrefab, spawnlocation.position, Quaternion.identity);
            counter++;
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnabler : MonoBehaviour {

    public BoxCollider activatorCol;
	
	void Start ()
    {
		
	}

    void Update ()
    {
		if (Input.GetKeyDown(KeyCode.E) && activatorCol.enabled == false)
        {
            activatorCol.enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.E) && activatorCol.enabled == true)
        {
            activatorCol.enabled = false;
        }
	}
}

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
		if (Input.GetKey(KeyCode.E) && activatorCol.enabled == false)
        {
            activatorCol.enabled = true;
        }
        else
        {
            activatorCol.enabled = false;
        }
	}
}

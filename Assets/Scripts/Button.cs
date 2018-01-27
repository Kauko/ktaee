using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public MeshRenderer mesh;
    public Material m1, m2;
    public bool ison;


    public void OnTriggerEnter(Collider other)
    {
       // CheckTrigger(other, Variables.firstrigger, "ButtonBalls");

        if (other.tag == "Activator" && !Variables.lightTrigger && gameObject.name == "ButtonLight")
        {
            mesh.material = m2;
            Variables.lightTrigger = true;
        }
        else if (other.tag == "Activator" && Variables.lightTrigger && gameObject.name == "ButtonLight")
        {
            mesh.material = m1;
            Variables.lightTrigger = false;
        } 

        else if (other.tag == "Activator" && !Variables.lightTrigger && gameObject.name == "ButtonBalls")
        {
            Variables.ballTrigger = true;
        }
        else if (other.tag == "Activator" && Variables.lightTrigger && gameObject.name == "ButtonBalls")
        {
            Variables.ballTrigger = false;        }

    }

    void CheckTrigger(Collider col, bool ison, string name)
    {
        if (col.tag == "Activator" && !ison && gameObject.name == name)
        {
            mesh.material = m2;
            ison = true;
        }
        else if (col.tag == "Activator" && ison && gameObject.name == name)
        {
            mesh.material = m1;
            ison = false;
        }
    }
}

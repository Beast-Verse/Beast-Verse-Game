using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) {
        
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

     void OnCollisionStay(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    void OnCollisionExit(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
    }
}

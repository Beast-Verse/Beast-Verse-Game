using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    [SerializeField] float health = 100;
    void OnCollisionEnter(Collision collision) {
        health -=10;
        DebugLog();
    }

    void OnCollisionStay(Collision collision)
    {
        health -=1;
        DebugLog();
    }

    void OnCollisionExit(Collision collision)
    {
        health -=5;
        DebugLog();
    }
    void DebugLog()
    {
        if (health > 0)
        {
            Debug.Log(health);  
        } 
        else 
        {
            Debug.Log("Enemy ded");
        }
        
    }
}

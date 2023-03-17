using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MonsterMovement();
    }

    void MonsterMovement()
    {
        float xAxis = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zAxis = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(xAxis,0,zAxis);
    }

    
}

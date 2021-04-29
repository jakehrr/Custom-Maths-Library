using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbLauncher : MonoBehaviour
{
    public GameObject orbCannon;
    public int speed = 500; 

    void Update()
    {
        RotateTurret();   
    }

    void RotateTurret()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.back * speed * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}

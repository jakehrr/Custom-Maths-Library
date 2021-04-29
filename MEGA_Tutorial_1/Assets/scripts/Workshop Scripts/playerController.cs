using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float speed = 5f;
    Vector3 forwardDirection = new Vector3();
    Vector3 rightDirection = new Vector3();

    // Update is called once per frame
    void Update()
    {
        playerControls();
    }

    void playerControls()
    {
        //calculateDirection();
        if (Input.GetKey(KeyCode.W))
        {
            transform.position -= forwardDirection * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += forwardDirection * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += rightDirection * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= rightDirection * speed * Time.deltaTime;
        }
    }
    
    //void calculateDirection()
    //{
    //    forwardDirection = MathsLib.EulerAnglesToDirection(transform.rotation.eulerAngles * Mathf.Deg2Rad).ToUnityVector();
    //    rightDirection = MathsLib.VectorCrossProduct(forwardDirection, Vector3.up).ToUnityVector();
    //}
    
}

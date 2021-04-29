using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] Transform _player; 

    private float speed = 3.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            MoveToPlayer();
        }
    }

    void MoveToPlayer()
    {
        // direction = destination - source
        Vector3 direction = _player.position - transform.position;
        direction.Normalize(); // Noramlize the vector for constant movement. 
        transform.Translate(direction * Time.deltaTime * speed); // Move the object in players direction 
    }
}

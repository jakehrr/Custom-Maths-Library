using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPObject : MonoBehaviour
{
    // Variables
    public GameObject movingObject; // Access the position of the object that will move.
    public GameObject playerObject; // Acess the position of the player.
    private Vector3 objectPosition; // Create a vector 3 variable to store as the transform.position. 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // if a key is pressed then the object will move to the capsules positon.
        {
            TeleportObject(); // Calling move function
        } 
    }

    public void TeleportObject() // Teleporting the cube to the capsule position
    {
        playerObject = GameObject.Find("PlayerMain"); // Access the position of the capsule 

        transform.position = objectPosition; // Set trasnform position to a Vector 3. 

        movingObject.transform.position = playerObject.transform.position + objectPosition; // Have the cubes position equal to the capsules.
    }
}

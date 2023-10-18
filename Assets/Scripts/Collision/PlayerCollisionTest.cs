using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionTest : MonoBehaviour
{

    //https://www.educative.io/answers/introduction-to-collision-detection-in-unity

    /*
    // Gets called at the start of the collision 
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entered collision with " + collision.gameObject.name);
    }

    // Gets called during the collision
    void OnCollisionStay(Collision collision)
    {
        Debug.Log("Colliding with " + collision.gameObject.name);
    }

    // Gets called when the object exits the collision
    void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exited collision with " + collision.gameObject.name);
    }
    */

    // Gets called when the object enters the collider area 
    void OnTriggerEnter(Collider objectName)
    {
        Debug.Log("Entered collision with " + objectName.gameObject.name);
    }

}

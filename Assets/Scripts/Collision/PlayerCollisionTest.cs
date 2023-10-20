using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionTest : MonoBehaviour
{

    public Material Material1;

    //https://www.educative.io/answers/introduction-to-collision-detection-in-unity

    // Gets called when the object enters the collider area 
    void OnTriggerEnter(Collider objectName)
    {
        Debug.Log("Entered collision with " + objectName.gameObject.name);
    }

}

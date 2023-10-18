using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerAddForce : MonoBehaviour
{

    //https://github.com/Mozikr/Csharp/blob/main/movement_AddForce.cs

    public int force ;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {       
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            GetComponent<Rigidbody>().AddForce(new Vector3(-force, 0, 0));
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            GetComponent<Rigidbody>().AddForce(new Vector3(force, 0, 0));
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, force));
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -force));

    }
}

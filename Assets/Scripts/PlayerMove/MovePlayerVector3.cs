using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerVector3 : MonoBehaviour
{

    [SerializeField] private float speed = 1f;
    [SerializeField] private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.velocity = dir * speed;
    }
}

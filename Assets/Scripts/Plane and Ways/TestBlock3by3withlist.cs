using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBlock3by3withlist : MonoBehaviour
{

    //public GameObject obj;

    public List<GameObject> block3by3 = new List<GameObject>();

    public Material Material1;

    private void Start()
    {
        //block3by3.Add(GetComponentInChildren<MeshRenderer>().material);
        block3by3[0].GetComponentInChildren<MeshRenderer>().material = Material1;
    }

}

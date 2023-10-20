using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWayFrom3by3Blocks : MonoBehaviour
{

    public GameObject obj;
    private GameObject[] newPlane = new GameObject[100];

    // Start is called before the first frame update
    void Start()
    {

        int k = 0;

        //Создаём подряд 40 блоков

        for (int i = 0; i < 40; i++)
        {
            newPlane[i] = Instantiate(obj, new Vector3(0, 0, k), Quaternion.Euler(0, 0, 0));
            k += 30;
        }

    }
}

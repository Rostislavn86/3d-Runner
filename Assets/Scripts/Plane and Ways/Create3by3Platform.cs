using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create3by3Platform : MonoBehaviour
{
    public GameObject obj;
    private GameObject[,] newPlane = new GameObject[3, 3];

    private void Start()
    {
        //Создаем поле 3*3 метров 

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                newPlane[i, j] = Instantiate(obj, new Vector3(i * 10, 0, j * 10), Quaternion.Euler(0, 0, 0));

            }
        }
    }
}

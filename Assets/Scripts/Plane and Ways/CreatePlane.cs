using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlane : MonoBehaviour
{
    public GameObject obj;
    private GameObject[,] newPlane = new GameObject[10,10];

    private void Start()
    {
        //Создаем поле 10*10 метров 

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                newPlane[i,j] = Instantiate(obj, new Vector3(i * 10, 0, j * 10), Quaternion.Euler(0, 0, 0));
                
            }
        }   
    }
}

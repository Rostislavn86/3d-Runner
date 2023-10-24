using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://docs.unity3d.com/ScriptReference/Component.GetComponentsInChildren.html

public class TestWorkWithBlock3by3 : MonoBehaviour
{
    public GameObject obj;
    public Material Material1;
    public Material WindTrap;
    public Material ThirdTrap;

    // Массив компонентов которые мы нашли с помпощью GetComponentsInChildren
    private Component[] hingeJoints;

    // Счётчик для ловушек
    int k = 0;

    void Start()
    {
        //Обращаемся через наследование к дочернему компоненту через GetComponentInChildren
        //   obj.GetComponentInChildren<Transform>().transform.localPosition = Vector3.zero;

        //Находим первое совпадение во вложенных объектах
        //obj.GetComponentInChildren<MeshRenderer>().material = Material1;

        //Находим все совпадения во вложенных объектах и создаём их них массив 
        hingeJoints = obj.GetComponentsInChildren<MeshRenderer>();

        //Debug.Log(hingeJoints);

        for (int i = 0; i < hingeJoints.Length; i++)
        {
            k++;
            if (k == 8) 
            {
                k = 0;
            }
            // Случайно отрисовываем ловушки и добавляем каждой клетке с ловушкой свой tag
            if (k == Random.Range(4, 8))
            {
                hingeJoints[i].GetComponent<MeshRenderer>().material = Material1;
                hingeJoints[i].tag = "FirstTrap";
            }
            // Случайно отрисовываем ловушки и добавляем каждой клетке с ловушкой свой tag
            if (k == Random.Range(4, 8))
            {
                hingeJoints[i].GetComponent<MeshRenderer>().material = WindTrap;
                hingeJoints[i].tag = "SecondTrap";
            }
            // Случайно отрисовываем ловушки и добавляем каждой клетке с ловушкой свой tag
            if (k == Random.Range(4, 8))
            {
                hingeJoints[i].GetComponent<MeshRenderer>().material = ThirdTrap;
                hingeJoints[i].tag = "ThirdTrap";
            }

        }
        
    }
}

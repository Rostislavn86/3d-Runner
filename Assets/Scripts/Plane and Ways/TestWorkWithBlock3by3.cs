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

    // ������ ����������� ������� �� ����� � �������� GetComponentsInChildren
    private Component[] hingeJoints;

    // ������� ��� �������
    int k = 0;

    void Start()
    {
        //���������� ����� ������������ � ��������� ���������� ����� GetComponentInChildren
        //   obj.GetComponentInChildren<Transform>().transform.localPosition = Vector3.zero;

        //������� ������ ���������� �� ��������� ��������
        //obj.GetComponentInChildren<MeshRenderer>().material = Material1;

        //������� ��� ���������� �� ��������� �������� � ������ �� ��� ������ 
        hingeJoints = obj.GetComponentsInChildren<MeshRenderer>();

        //Debug.Log(hingeJoints);

        for (int i = 0; i < hingeJoints.Length; i++)
        {
            k++;
            if (k == 8) 
            {
                k = 0;
            }
            // �������� ������������ ������� � ��������� ������ ������ � �������� ���� tag
            if (k == Random.Range(4, 8))
            {
                hingeJoints[i].GetComponent<MeshRenderer>().material = Material1;
                hingeJoints[i].tag = "FirstTrap";
            }
            // �������� ������������ ������� � ��������� ������ ������ � �������� ���� tag
            if (k == Random.Range(4, 8))
            {
                hingeJoints[i].GetComponent<MeshRenderer>().material = WindTrap;
                hingeJoints[i].tag = "SecondTrap";
            }
            // �������� ������������ ������� � ��������� ������ ������ � �������� ���� tag
            if (k == Random.Range(4, 8))
            {
                hingeJoints[i].GetComponent<MeshRenderer>().material = ThirdTrap;
                hingeJoints[i].tag = "ThirdTrap";
            }

        }
        
    }
}

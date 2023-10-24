using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerCollisionFirstTrap : MonoBehaviour
{
    public Material FirstTrapCollisionEnterMaterial;
    public Material ActivateTrapAfterCollision;
    public Material SetDamageToThePlayer;

    public Material ReloadTrap;

    void OnTriggerEnter(Collider objectName)
    {

        //https://stackoverflow.com/questions/65455308/how-to-get-all-the-materials-assigned-to-a-gameobject-in-unity#:~:text=In%20Unity%2C%20we%20can%20get,get%20one%20material%20per%20GameObject.

        /*
        //���������� ��������� �� ����� ���������� ������������� � �������� ��������� � ������� ���������� ������� 
        // ��� �� ���������� ����� �� ������ �� �������
        if (objectName.GetComponent<Renderer>().material.name.ToString().Contains(FirstTrapCollisionEnterMaterial.name)
            == true)

        {
            //������������ ����� � ������������ ��������
            StartCoroutine(CreateDamageToThePlayer(objectName));
        }
        */

        //���������� �� ���� - ������ �� �� � ������� 
        if (objectName.tag == "FirstTrap")
        {
            //������������ ����� � ������������ ��������
            StartCoroutine(CreateDamageToThePlayer(objectName));
        }
    }

    //Courutine ������� �������� �� ��������� ��������� �������
    private IEnumerator CreateDamageToThePlayer(Collider planeCollider)
    {
        //���� �� ������� �������� ����� ���������� ���������� ������
        planeCollider.GetComponent<Renderer>().material = ActivateTrapAfterCollision;
        yield return new WaitForSeconds(1f);
        planeCollider.GetComponent<Renderer>().material = SetDamageToThePlayer;
        yield return new WaitForSeconds(0.6f);
        planeCollider.GetComponent<Renderer>().material = ReloadTrap;
        yield return new WaitForSeconds(5f);
        planeCollider.GetComponent<Renderer>().material = FirstTrapCollisionEnterMaterial;
    }
}

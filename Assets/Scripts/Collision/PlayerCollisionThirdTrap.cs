using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerCollisionThirdTrap : MonoBehaviour
{

    public Material ThirdTrap;
    public Material ThirdTrapAfterCollision;
    public Material ThirdTrapDamage;
    // Start is called before the first frame update

    public Vector3 teleportPoint;

    
    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.GetComponent<Renderer>().material);

        if (other.GetComponent<Renderer>().material.name.ToString().Contains("ThirdTrapDamage"))
        {
            
            teleportPoint = new Vector3(Random.Range(10, 75), 3.5f, Random.Range(25, 56));

            this.transform.position = teleportPoint;

        }     
    }
    

    void OnTriggerEnter(Collider objectName)
    {
        /*
        //https://stackoverflow.com/questions/65455308/how-to-get-all-the-materials-assigned-to-a-gameobject-in-unity#:~:text=In%20Unity%2C%20we%20can%20get,get%20one%20material%20per%20GameObject.
        // ������� ��� ��������� ������� ��������� � �������

        //���������� ��������� �� ����� ���������� ������������� � �������� ��������� � ������� ���������� ������� 
        // ��� �� ���������� ����� �� ������ �� �������
        if (objectName.GetComponent<Renderer>().material.name.ToString().Contains(ThirdTrap.name)
            == true)

        {

            //������������ ����� � ������������ ��������
            StartCoroutine(CreateDamageToThePlayer(objectName));
        }
        */

        //���������� �� ���� - ������ �� �� � ������� 
        if (objectName.tag == "ThirdTrap")
        {
            //������������ ����� � ������������ ��������
            StartCoroutine(CreateDamageToThePlayer(objectName));
        }

    }

    void OnTriggerExit(Collider objectName)
    {
        /*
        //https://stackoverflow.com/questions/65455308/how-to-get-all-the-materials-assigned-to-a-gameobject-in-unity#:~:text=In%20Unity%2C%20we%20can%20get,get%20one%20material%20per%20GameObject.
        // ������� ��� ��������� ������� ��������� � �������
        //Debug.Log(objectName.GetComponent<Renderer>().material.name);

        //���������� ��������� �� ����� ���������� ������������� � �������� ��������� � ������� ���������� ������� 
        // ��� �� ���������� ����� �� ������ �� �������
        if (objectName.GetComponent<Renderer>().material.name.ToString().Contains(ThirdTrap.name)
            == true)

        {
            objectName.GetComponent<Renderer>().material = ThirdTrap;
        }
        */

        //���������� �� ���� - ������ �� �� � ������� 
        if (objectName.tag == "ThirdTrap")
        {
            //������������ ����� � ������������ ��������
            StartCoroutine(CreateDamageToThePlayer(objectName));
        }
    }



    private IEnumerator CreateDamageToThePlayer(Collider planeCollider)
    {
        //���� �� ������� �������� ����� ���������� ���������� ������
        planeCollider.GetComponent<Renderer>().material = ThirdTrapAfterCollision;
        yield return new WaitForSeconds(2f);
        planeCollider.GetComponent<Renderer>().material = ThirdTrapDamage;
        yield return new WaitForSeconds(2f);
        planeCollider.GetComponent<Renderer>().material = ThirdTrap;

    }

}

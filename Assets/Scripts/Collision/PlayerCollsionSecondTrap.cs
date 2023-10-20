using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerCollsionSecondTrap : MonoBehaviour
{

    public Material WindTrap;
    public Material WindTrapAfterCollision;

    public int windForce = 100;

    private bool windZone = false;

    public int randomFromForceToTheDifferentWays;

    // Start is called before the first frame update
    void Start()
    {
        //Вызываем фунцию выбора направления ветра каждые 2 секунды
        InvokeRepeating("ForceToTheDifferentWays", 0.0f, 2.0f);        
    }

    // Update is called once per frame
    void Update()
    {

        

    }

    private void FixedUpdate()
    {

        if (windZone)
        {
            switch (randomFromForceToTheDifferentWays)
            {
                case 1:
                    this.GetComponent<Rigidbody>().AddForce(new Vector3(-windForce, 0, 0));
                    break;
                case 2:
                    this.GetComponent<Rigidbody>().AddForce(new Vector3(windForce, 0, 0));
                    break;
                case 3:
                    this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, windForce));
                    break;
                case 4:
                    this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -windForce));
                    break;
            }
        }
    }

    void OnTriggerEnter(Collider objectName)
    {

        //https://stackoverflow.com/questions/65455308/how-to-get-all-the-materials-assigned-to-a-gameobject-in-unity#:~:text=In%20Unity%2C%20we%20can%20get,get%20one%20material%20per%20GameObject.
        // Находим имя материала который прикреплён к объекту

        //Сравниваем сходяться ли имена материалов обработанного в коллизии материала с искомым материалом ловушки 
        // Так мы определяем попал ли объект на ловушку
        if (objectName.GetComponent<Renderer>().material.name.ToString().Contains(WindTrap.name)
            == true)

        {
            objectName.GetComponent<Renderer>().material = WindTrapAfterCollision;

            windZone = true;
        }
    }

    void OnTriggerExit(Collider objectName)
    {

        //https://stackoverflow.com/questions/65455308/how-to-get-all-the-materials-assigned-to-a-gameobject-in-unity#:~:text=In%20Unity%2C%20we%20can%20get,get%20one%20material%20per%20GameObject.
        // Находим имя материала который прикреплён к объекту
        //Debug.Log(objectName.GetComponent<Renderer>().material.name);

        //Сравниваем сходяться ли имена материалов обработанного в коллизии материала с искомым материалом ловушки 
        // Так мы определяем попал ли объект на ловушку
        if (objectName.GetComponent<Renderer>().material.name.ToString().Contains(WindTrap.name)
            == true)
        {
            objectName.GetComponent<Renderer>().material = WindTrap;

            windZone = false;
        }
    }

    private void ForceToTheDifferentWays()
    {
        
        int s = Random.Range(1, 5);
        
        randomFromForceToTheDifferentWays = s;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    float elaspedTime;

    bool timeOn = false;

    public GameObject winPanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeOn == false)
        {
        
        }
        if (timeOn == true)
        {
            StartTimer();
         
        }
        

    }

    void OnTriggerEnter(Collider objectName)
    {
        if (objectName.GetComponent<Renderer>().material.name.ToString().Contains("StartPointMaterial")
            == true)

        {
         //     Debug.Log(objectName.GetComponent<Renderer>().material.name);
         //     Debug.Log("StartPointMaterial");

            timeOn = true;
        }

        if (objectName.tag == "Finish Point")

        {
            //     Debug.Log(objectName.GetComponent<Renderer>().material.name);
            //     Debug.Log("StartPointMaterial");

            timeOn = false;

            winPanel.SetActive(true);
        }
    }

    void StartTimer()
    {
        elaspedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elaspedTime / 60);
        int seconds = Mathf.FloorToInt(elaspedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}

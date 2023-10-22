using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    float elaspedTime;

    public bool timeOn = false;

    public GameObject winPanel;

    public GameObject losePanel;

    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {



        if (timeOn == false)
        {
            StopTimer();
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
            losePanel.SetActive(false);

            // Ставим игру на паузу
            Time.timeScale = 0.0f;
        }
    }

    void StartTimer()
    {
        elaspedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elaspedTime / 60);
        int seconds = Mathf.FloorToInt(elaspedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void StopTimer()
    {
        elaspedTime += 0;
        int minutes = Mathf.FloorToInt(elaspedTime / 60);
        int seconds = Mathf.FloorToInt(elaspedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}

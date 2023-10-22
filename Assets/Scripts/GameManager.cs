using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject winPanel;
    public GameObject losePanel;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < 0)
        {
            losePanel.SetActive(true);
            winPanel.SetActive(false);
            // Ставим игру на паузу
            Time.timeScale = 0.0f;
        }

        


    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHelth : MonoBehaviour
{

    public int maxHealth = 120;
    public int currentHealth;

    public HealthBar healthBar;

    public Material SetDamageToThePlayer;

    public GameObject winPanel;
    public GameObject losePanel;

    void OnTriggerStay(Collider objectName)
    {
        if (objectName.GetComponent<Renderer>().material.name.ToString().Contains(SetDamageToThePlayer.name))
        {
            TakeDamage(1);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            losePanel.SetActive(true);
            winPanel.SetActive(false);
            // Ставим игру на паузу
            Time.timeScale = 0.0f;
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage ;

        healthBar.SetHealth(currentHealth);
    }
}

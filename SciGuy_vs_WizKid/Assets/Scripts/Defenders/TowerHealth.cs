using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TowerHealth : MonoBehaviour
{
    public float startingHealth;
    public float currentHealth;

    public Canvas healthCanvas;
    public Slider healthBar;
    private Transform ownerTransform;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;

        ownerTransform = gameObject.GetComponent<Transform>();
        healthBar = healthCanvas.GetComponentInChildren<Slider>();
        healthBar.maxValue = startingHealth;
        healthBar.value = startingHealth; //may not be needed, not sure w/ what values slider is initialized with
    }

    // Update is called once per frame
    void Update()
    {

        if (currentHealth < 0)
        {
            Destroy(gameObject);
        }
        healthBar.value = currentHealth;
    }

}
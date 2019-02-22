using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackerColliderHealth : MonoBehaviour
{
    public float startingHealth = 100;
    public float currentHealth;

    private bool isColliding;

    public Canvas healthPrefab;
    public Canvas healthCanvas;
    public Slider healthBar;
    public float offsetYHealth = 1.5f;
    private Transform ownerTransform; 

    // Start is called before the first frame update
    private void Awake()
    {



    }
    void Start()
    {
        currentHealth = startingHealth;

        ownerTransform = gameObject.GetComponent<Transform>();
        Canvas instance = Instantiate(healthPrefab, new Vector3(0,0,0), Quaternion.identity, gameObject.transform);
        healthCanvas = instance; // store reference to its canvas so don't have to look for it
        healthBar = healthCanvas.GetComponentInChildren<Slider>();
        //healthBar.transform.position = new Vector2(ownerTransform.position.x, (ownerTransform.position.y + offsetYHealth));
        healthBar.maxValue = startingHealth;
        healthBar.value = startingHealth; //may not be needed, not sure w/ what values slider is initialized with
    }

    // Update is called once per frame
    void Update()
    {
        isColliding = false;
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isColliding) return;
        isColliding = true;
        if(collision.gameObject.tag == "Projectile")
        {
            takeDamage();
        }
    }

    private void takeDamage()
    {
        currentHealth -= 10; // later change this to accessing projectile's dmg
        Debug.Log("Current health is " + currentHealth);
        healthBar.value = currentHealth; 
    }
}

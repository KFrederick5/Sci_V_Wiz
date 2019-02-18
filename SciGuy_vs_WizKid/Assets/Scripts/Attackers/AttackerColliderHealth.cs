using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerColliderHealth : MonoBehaviour
{
    public float health;
    private bool isColliding;
    // Start is called before the first frame update
    private void Awake()
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isColliding = false;
        if(health <= 0)
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
            health -= 10;
            Debug.Log("Current health is " + health);
        }
    }
}

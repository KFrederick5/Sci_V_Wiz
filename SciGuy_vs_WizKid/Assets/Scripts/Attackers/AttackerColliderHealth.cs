using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerColliderHealth : MonoBehaviour
{
    public float health;

    // Start is called before the first frame update
    private void Awake()
    {
        health = 100.0f;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            health -= 10;
            Debug.Log("Current health is" + health);
        }
    }
}

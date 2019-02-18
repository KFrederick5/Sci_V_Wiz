using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTrigger : MonoBehaviour
{
    private int count;
    GameObject tower;
    public static int num_enemies = 0;
    public static int start_count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        num_enemies = transform.childCount;
        start_count = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (num_enemies > start_count)
        {
            ProjectileSpawner spawner = GetComponentInChildren<ProjectileSpawner>();
            spawner.enabled = true;
            Debug.Log(num_enemies);
        }
        else if (num_enemies == start_count)
        {
            ProjectileSpawner spawner = GetComponentInChildren<ProjectileSpawner>();
            spawner.enabled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Attacker"))
        {
            num_enemies += 1;
            other.transform.parent = transform;

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Attacker"))
        {
            ProjectileSpawner spawner = GetComponentInChildren<ProjectileSpawner>();
            spawner.enabled = false;

        }
    }
}

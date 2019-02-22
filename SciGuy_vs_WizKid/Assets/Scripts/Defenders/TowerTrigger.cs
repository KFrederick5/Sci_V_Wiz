using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTrigger : MonoBehaviour
{
    public bool enemies = false;

    // Update is called once per frame
    void Update()
    {
        AttackerCounter enemies_in_lane = GetComponentInChildren<AttackerCounter>();
        enemies = enemies_in_lane.enemies_in_lane;
    }

    /*void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Attacker"))
        {
            num_enemies_private += 1;
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
    }*/
}

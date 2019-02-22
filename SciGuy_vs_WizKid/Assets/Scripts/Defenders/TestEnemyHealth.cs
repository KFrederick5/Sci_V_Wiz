using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyHealth : MonoBehaviour
{
    public GameObject ship;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D Projectile)
    {
        //Debug.Log("REEEEE");
        this.gameObject.SetActive(false);
    }
}

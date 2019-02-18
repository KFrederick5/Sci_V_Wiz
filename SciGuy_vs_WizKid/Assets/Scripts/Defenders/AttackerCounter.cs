using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerCounter : MonoBehaviour
{
    public int num_enemies = 0;
    public bool enemies_in_lane = false;
    // Start is called before the first frame update
    void Start()
    {
        num_enemies = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        num_enemies = transform.childCount;
        //Debug.Log(num_enemies);
        if (num_enemies > 0)
        {
            enemies_in_lane = true;
        }
        else if (num_enemies == 0)
        {
            enemies_in_lane = false;
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
}

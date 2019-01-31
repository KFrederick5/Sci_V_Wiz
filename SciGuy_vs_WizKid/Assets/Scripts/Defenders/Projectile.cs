using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed = 0.2f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0.0f, 0.0f);
    }
}

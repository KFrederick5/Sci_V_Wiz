using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public bool enabled = false;
    public GameObject Prefab;
    public float timeScale = 1.0f;
    public float currentTime = 0.0f;
    // Start is called before the first frame update
    void Update()
    {
        TowerTrigger enemies = GetComponentInParent<TowerTrigger>();
        enabled = enemies.enemies;
        //Debug.Log(enemies);
        currentTime += Time.deltaTime;
        if ((currentTime >= timeScale) && enabled)
        {
            GameObject go;
            go = Instantiate(Prefab) as GameObject;
            go.transform.parent = transform;
            currentTime = 0.0f;
        }
    }
    



}

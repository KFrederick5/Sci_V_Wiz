using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public bool enabled = true;
    public GameObject Prefab;
    public float timeScale = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(timeScale);
            GameObject go;
            go = Instantiate(Prefab) as GameObject;
            go.transform.parent = transform;
        }
    }

}

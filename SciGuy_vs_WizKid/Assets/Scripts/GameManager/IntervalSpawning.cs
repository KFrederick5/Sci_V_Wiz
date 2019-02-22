using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IntervalSpawning : MonoBehaviour
{
    // Start is called before the first frame update
    public Stack<GameObject> AttackerQueue;
    public GameObject b;
    private int time;
    void Awake()
    {
        AttackerQueue = new Stack<UnityEngine.GameObject>();
    }
    void Start()
    {
        AttackerQueue.Push(b);
        AttackerQueue.Push(b);
        AttackerQueue.Push(b);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
            StartCoroutine(IntervalSpawn(AttackerQueue));
    }

    IEnumerator IntervalSpawn(Stack<GameObject> AttackerList)
    {
        while (AttackerList.Count > 0)
        {
            Instantiate(AttackerList.Pop() as GameObject);
            Debug.Log("Popping");
            time = Random.Range(2, 5); //Wait between 2 to 5 seconds before spawning
            yield return new WaitForSeconds(time);
        }
    }
}

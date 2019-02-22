using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public int rows = 10;

    public GameObject lane;
    public Transform grid;
    [SerializeField]
    private List<Transform> spawnList;

    public List<Transform> SpawnList { get => spawnList;}

    private void Awake()
    {
        SetupLevel();
    }
    void SetupLevel()
    {
        grid = new GameObject ("Grid").transform;
        for (int y = 0; y < rows; y++)
        {
            GameObject instance = Instantiate(lane, new Vector3(0, y, 0f), Quaternion.identity, grid) as GameObject;
            SpawnList.Add(instance.transform.Find("Items").transform.Find("Attackers"));
            
        }
    }
}
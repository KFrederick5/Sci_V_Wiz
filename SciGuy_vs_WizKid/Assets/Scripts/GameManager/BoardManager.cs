using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public int columns = 16;
    public int rows = 5;

    public GameObject grass;
    public GameObject street;
    public Transform grid;

    private void Start()
    {
        SetupLevel();
    }
    void SetupLevel()
    {
        grid = new GameObject ("Grid").transform;
        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < rows; y++)
            {
                if (x == 7)
                {
                    GameObject instance = Instantiate(street, new Vector3(x, y, 0f), Quaternion.identity, grid) as GameObject;
                }
                else if (x==8)
                {
                    GameObject instance = Instantiate(street, new Vector3(x, y, 0f), Quaternion.Euler(0,180,0), grid) as GameObject;

                }
                else
                {
                    GameObject instance = Instantiate(grass, new Vector3(x, y, 0f), Quaternion.identity, grid) as GameObject;
                }
                //vector3 bc i guess creating vector2 converts to vector3 anyways
            }
        }
    }
}

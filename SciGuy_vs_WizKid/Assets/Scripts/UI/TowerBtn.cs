using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBtn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject towerButton;
    public int price;

    public GameObject TowerButton 
    {
        get 
        {
            return towerButton; //Returns gameobject attached to button
        
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

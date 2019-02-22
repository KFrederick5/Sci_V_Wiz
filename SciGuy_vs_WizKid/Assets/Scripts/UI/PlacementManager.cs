﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlacementManager : MonoBehaviour
{
    // Start is called before the first frame update

    public TowerBtn clickedBtn{ get; private set; }
    Vector2 ray;
    RaycastHit2D hit;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hit = Physics2D.Raycast(ray, Vector2.zero);
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0) && hit)
            {
                if (hit.transform.tag == "Ground" && hit.transform.childCount == 0)
                {
                    PlaceTower(hit.transform); //Place Tower on hit transform, only if the hit is a 'Ground' tag and there isn't anything else parented to it
                }
            }
        }
    }

    public void SetTower(TowerBtn tower)
    {
        this.clickedBtn = tower;
        Debug.Log("got" + tower);
    }

    public void PlaceTower(Transform ground) 
    {
        Instantiate(this.clickedBtn.TowerButton, ground); //Instantiate on Transform argument

    }
}
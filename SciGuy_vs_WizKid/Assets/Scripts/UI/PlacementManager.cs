using System.Collections;
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
                if (hit.transform.tag == "Ground")
                {
                    PlaceTower(hit.transform);
                    Debug.Log(hit.transform);
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
        Debug.Log("x: " + roundFloat(Input.mousePosition.x) + " y: " + roundFloat(Input.mousePosition.y));
        Instantiate(this.clickedBtn.TowerButton, ground);
        //Instantiate(this.clickedBtn.TowerButton, Camera.main.ScreenToWorldPoint(new Vector3(roundFloat(Input.mousePosition.x), roundFloat(Input.mousePosition.y), 10)), Quaternion.identity);
        //Instantiate(this.clickedBtn.TowerButton,Camera.main.ScreenToWorldPoint(new Vector3(roundFloat(Input.mousePosition.x), roundFloat(Input.mousePosition.y), 10)), Quaternion.identity);

    }

    public int roundFloat(float f)
    {
        if(f % 10 >= 5)
        {
            return (int)(f) + 5 ;
        }
        else
        {
            return (int)(f);
        }
    }
}
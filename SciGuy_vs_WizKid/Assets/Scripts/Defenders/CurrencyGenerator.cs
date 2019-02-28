using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyGenerator : MonoBehaviour
{

    public string stringToEdit = "";
    public string baseString = "Currency: ";
    public float testNumber = 0;
    public float timeScale = 1.0f;
    public float currentTime = 0.0f;
    public GameObject variableManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }
         

    // Update is called once per frame
    void Update()
    {
        variableManager = GameObject.Find("DefenseVariableManager");
        DefenseUnitComponent defense = variableManager.GetComponent<DefenseUnitComponent>();
        testNumber = defense.currentCurrency;
        
        stringToEdit = baseString + testNumber;
        currentTime += Time.deltaTime;
        if ((currentTime >= timeScale))
        {
            defense.currentCurrency += 10;
            
            currentTime = 0.0f;
        }
    }
}

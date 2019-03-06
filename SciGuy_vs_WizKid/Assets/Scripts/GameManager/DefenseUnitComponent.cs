using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseUnitComponent : MonoBehaviour
{
    public int cost = 100;
    public float health = 20.0f;
    public float damage = 5.0f;
    public float attack_speed = 0.5f;
    public int currentCurrency = 0;
    public string stringToEdit = "";
    public string baseString = "Currency: ";
    public float testNumber = 0;
    public string currentPlayer = "WizKid";
    public int WizCurrency = 300;
    public int SciCurrency = 300;
    void Update()
    {
        if (currentPlayer == "WizKid")
        {
            currentCurrency = WizCurrency;
        }
        if (currentPlayer == "SciGuy")
        {
            currentCurrency = SciCurrency;
        }
        if (Input.GetKeyDown(KeyCode.Q))//test switcher. The actual switcher will be something else
        {
            Debug.Log(currentPlayer);
            if (currentPlayer == "WizKid")
            {
                currentPlayer = "SciGuy";
                Debug.Log("switching");
            }
            else if (currentPlayer == "SciGuy")
            {
                currentPlayer = "WizKid";
                Debug.Log("switching");

            }
            
        }
        
            testNumber = currentCurrency;
        stringToEdit = "Current Player: " + currentPlayer + baseString + testNumber;
    }
    void OnGUI()
    {
        // Make a text field that modifies stringToEdit.
        stringToEdit = GUI.TextField(new Rect(10, 10, 400, 20), stringToEdit, 50);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseUnitComponent : MonoBehaviour
{
    public int cost = 100;
    public float health = 20.0f;
    public float damage = 5.0f;
    public float attack_speed = 0.5f;
    public int currentCurrency = 300;
    public string stringToEdit = "";
    public string baseString = "Currency: ";
    public float testNumber = 0;
    void Update()
    {
        testNumber = currentCurrency;
        stringToEdit = baseString + testNumber;
    }
    void OnGUI()
    {
        // Make a text field that modifies stringToEdit.
        stringToEdit = GUI.TextField(new Rect(10, 10, 200, 20), stringToEdit, 25);
    }
}

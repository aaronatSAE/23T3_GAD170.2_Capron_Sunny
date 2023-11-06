using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Plant : MonoBehaviour
{
    // My plant has a dollar value, health, and species
    private string speciesName = "Unnamed Plant";
    private int myPrice = 0;
    private float myHealth = 0;

    public void SetInitialStats(int newHealth, int newPrice, string newName)
    {
        myHealth = newHealth;
        myPrice = newPrice;
        speciesName = newName;
    }

    public void SetSpeciesName(string newName)
    {
        speciesName = newName;
    }

    public string GetSpeciesName()
    {
        return speciesName;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetSpeciesName("Violet");
        Debug.Log("Species name is: " + GetSpeciesName());
    }
}

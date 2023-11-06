using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greenhouse : MonoBehaviour
{
    public Plant plantPrefab;
    public List<Plant> plants;

    public void CreateNewPlant()
    {
        Plant newPlant = Instantiate(plantPrefab) as Plant;
        newPlant.SetInitialStats(100, 100, "Snapdragon");
    }
}

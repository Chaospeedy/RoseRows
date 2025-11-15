using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Rendering;

public class GrowthManager : MonoBehaviour
{
    private List<Rose> roses = new List<Rose>();

    public static GrowthManager instance;

    




    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {
        foreach (Rose rose in roses)
        {
            rose.checkGrowth(Time.deltaTime);
        }
    }

    public void AddRose(Rose rose)
    {
        roses.Add(rose);
    }

    public void RemoveRose(Rose rose)
    {
        roses.Remove(rose);
    }

    public int HarvestRose(Rose rose)
    {
        CheckAdjacentPlots(rose);
        return 1;
    }

    public void CheckAdjacentPlots(Rose rose)
    {
        if (rose.adjacency[0])
        {
            Debug.Log("plot " + rose.plotNumber + " has adjacency Up of color " + rose.adjUp.color);
        }
        if (rose.adjacency[1])
        {
            Debug.Log("plot " + rose.plotNumber + " has adjacency Down of color " + rose.adjDown.color);
        }
        if (rose.adjacency[2])
        {
            Debug.Log("plot " + rose.plotNumber + " has adjacency Right of color " + rose.adjRight.color);
        }
        if (rose.adjacency[3])
        {
            Debug.Log("plot " + rose.plotNumber + " has adjacency Left of color " + rose.adjLeft.color);
        }
    }

}

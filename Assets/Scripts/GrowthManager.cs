using System.Collections.Generic;
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
    


}

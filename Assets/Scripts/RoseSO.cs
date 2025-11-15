using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "RoseSO", menuName = "Scriptable Objects/RoseSO")]
public class RoseSO : ScriptableObject
{
    public string roseName;
    public int roseColor;
    public List<Sprite> roseSprites;

    public float growthTime;
    public int seedReturn;

    public int growthStageMaxmimum = 4;

    public Sprite GetGrowthStage(int stage)
    {
        if (stage >= growthStageMaxmimum)
        {
            return null;
        }
        return roseSprites[stage];
    }
}

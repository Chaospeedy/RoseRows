using System.Linq;
using UnityEngine;

public class Rose : MonoBehaviour
{
    [SerializeField] private RoseSO rose;
    [SerializeField] public Rose adjUp, adjDown, adjRight, adjLeft = null;

    private SpriteRenderer spriteRenderer;
    public int currentGrowthStage = 0;
    private float currentTime;
    public int plotNumber;

    public int color;

    public bool[] adjacency = new bool[4];

    void Start()
    {
        GrowthManager.instance.AddRose(this);
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = rose.roseSprites[0];
        color = rose.roseColor;
        if (plotNumber + 3 <= 8)//up
        {
            adjacency[0] = true;
        }
        if (plotNumber - 3 >= 0)//down
        {
            adjacency[1] = true;
        }
        if (plotNumber + 1 <= 8 && (plotNumber + 1) % 3 != 0)//right
        {
            adjacency[2] = true;
        }
        if (plotNumber - 1 >= 0 && (plotNumber - 1) % 3 != 2)//left
        {
            adjacency[3] = true;
        }
    }

    public void checkGrowth(float deltaTime)
    {
        currentTime += deltaTime;
        if (currentTime >= rose.growthTime && currentGrowthStage != rose.growthStageMaxmimum)
        {
            currentGrowthStage++;
            currentTime = 0;
            spriteRenderer.sprite = rose.roseSprites[currentGrowthStage];

            Debug.Log(currentGrowthStage);

            if (currentGrowthStage == rose.growthStageMaxmimum - 1)
            {
                GrowthManager.instance.RemoveRose(this);
            }
        }
    }

    void OnMouseDown()
    {
        if (currentGrowthStage == rose.growthStageMaxmimum - 1)
        {
            GrowthManager.instance.HarvestRose(this);
        }
    }


}

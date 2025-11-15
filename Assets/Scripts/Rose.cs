using UnityEngine;

public class Rose : MonoBehaviour
{
    [SerializeField] private RoseSO rose;

    private SpriteRenderer spriteRenderer;
    public int currentGrowthStage = 0;
    private float currentTime;
    public int plotNumber;



    void Start()
    {
        GrowthManager.instance.AddRose(this);
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = rose.roseSprites[0];
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
                //GrowthManager.instance.RemoveRose(this);
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

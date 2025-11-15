using UnityEngine;

public class Rose : MonoBehaviour
{
    [SerializeField] private RoseSO rose;
    private SpriteRenderer spriteRenderer;
    public int currentGrowthStage = 0;
    public float currentTime;

    void Start()
    {
        GrowthManager.instance.AddRose(this);
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = rose.roseSprites[0];
    }

    public void checkGrowth(float deltaTime)
    {
        currentTime += deltaTime;
        if (currentTime >= rose.growthTime)
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
}

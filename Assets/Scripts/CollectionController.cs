using UnityEngine;

public class CollectionController : MonoBehaviour
{
    [SerializeField] private CollectionPage collection;

    public int collectionSize = 10;
    void Start()
    {
        collection.InitializeCollection(collectionSize);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (collection.isActiveAndEnabled)
            {
                collection.CloseCollection();
            }
            else
            {
                collection.OpenCollection();
            }
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

public class CollectionPage : MonoBehaviour
{
    [SerializeField] private CollectionEntry collectionRose;

    [SerializeField] private RectTransform contentPanel;

    List<CollectionEntry> listOfEntries = new List<CollectionEntry>();

    public void InitializeCollection(int collectionSize)
    {
        for (int i = 0; i < collectionSize; i++)
        {
            CollectionEntry entry = Instantiate(collectionRose, Vector2.zero, Quaternion.identity);
            entry.transform.SetParent(contentPanel);
            listOfEntries.Add(entry);
        }
    }

    public void OpenCollection()
    {
        gameObject.SetActive(true);
    }

    public void CloseCollection()
    {
        gameObject.SetActive(false);
    }
}

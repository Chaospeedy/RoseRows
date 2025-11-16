using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CollectionEntry : MonoBehaviour
{
    [SerializeField] private Image entryImage;
    public RoseSO roseSO;

    //private bool empty = true;

    void Awake()
    {
        //ResetData();
    }

    public void ResetData()
    {
        this.entryImage.gameObject.SetActive(false);
    }
    public void CreateEntry(Sprite sprite)
    {
        this.entryImage.gameObject.SetActive(true);
        this.entryImage.sprite = sprite;
        //empty = false;
    }

}

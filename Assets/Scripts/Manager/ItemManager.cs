using System.Collections.Generic;
using UnityEngine;

public class ItemManager : Singleton<ItemManager>
{
    public Inventory Inventory;
    public Equipment Equipment;
    public List<ItemData> itemDatas;

    private void Awake()
    {
        Inventory = FindObjectOfType<Inventory>();
    }
}
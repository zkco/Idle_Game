using System.Collections.Generic;
using UnityEngine;

public class ItemManager : Singleton<ItemManager>
{
    public Inventory Inventory;
    public List<ItemData> itemDatas;
    //public Item MakeItem()
    //{
    //    Item item = Instantiate(new GameObject()).AddComponent<Item>();


    //}
}
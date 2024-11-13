using System;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : Singleton<ItemManager>
{
    public Inventory Inventory;
    public Equipment Equipment;
    public List<ItemData> itemDatas;
}
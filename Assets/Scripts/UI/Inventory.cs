using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Queue<Slot> InventoryQueue;
    public Item item;


    private void Awake()
    {
        ItemManager.Instance.Inventory = this;
        InventoryQueue = new Queue<Slot>();
        Slot[] slots = GetComponentsInChildren<Slot>();
        foreach (Slot slot in slots)
        {
            InventoryQueue.Enqueue(slot);
        }
    }

    private void Start()
    {
        SetItem(item);
        SetItem(item);
        SetItem(item);
        SetItem(item);
        SetItem(item);
        SetItem(item);
        SetItem(item);
        SetItem(item);
        SetItem(item);
        SetItem(item);
        SetItem(item);
    }

    public void ShowInventory()
    {
        foreach (Slot slot in InventoryQueue)
        {
            slot.IconChange();
        }
    }

    /// <summary>
    /// 인벤토리에 item 추가
    /// </summary>
    /// <param name="item"></param>
    public void SetItem(Item item)
    {
        if(InventoryQueue.Any(slot => slot.Item == null))
        {
            InventoryQueue.First(slot => slot.Item == null).Item = item;
        }
        else
        {
            Debug.Log("아이템 가득 참");
        }
    }

    /// <summary>
    /// slot.Item = null
    /// </summary>
    /// <param name="slot"></param>
    public void RemoveItem(Slot slot)
    {
        slot.Item = null;
    }
}
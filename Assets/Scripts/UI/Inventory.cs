using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Queue<Slot> InventoryQueue;
    public Item item;
    public bool SellMode;

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
        if (InventoryQueue.Any(slot => slot.Item == null))
        {
            InventoryQueue.First(slot => slot.Item == null).Item = item;
        }
        else
        {
            Debug.Log("아이템 가득 참");
        }
    }

    /// <summary>
    /// slot.Item 을 null로 변환
    /// </summary>
    /// <param name="slot"></param>
    public void RemoveItem(Slot slot)
    {
        GameManager.Instance.Character.Gold += slot.Item.Data.Price;
        slot.Item = null;
    }
}
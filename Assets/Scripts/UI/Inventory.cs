using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Dictionary<string, Queue<Slot>> SlotByEquipPlace;


    private void Awake()
    {
        SlotByEquipPlace = new Dictionary<string, Queue<Slot>>();
        Slot[] slots = GetComponentsInChildren<Slot>();
        for (int i = 0; i < 4; i++)
        {
            Queue<Slot> Slots = new Queue<Slot>();
            string tag = ((EquipSlot)i).ToString();
            for (int j = 0; j < slots.Length; j++)
            {
                Slots.Enqueue(slots[j]);
            }
            SlotByEquipPlace.Add(tag, Slots);
        }
        ItemManager.Instance.Inventory = this;
    }

    public Item GetItem(string tag, string name)
    {
        Item item = new Item();
        //�κ��丮 ������ tag�� �´� ������ ������ ȣ�� > ���� ������ �������� ������
        if(SlotByEquipPlace[tag] != null)
        {
            Slot slot = SlotByEquipPlace[tag].First(slot => slot.Item.Data.Name == name);
            item = slot.Item;
        }
        return item;
    }

    public void SetItem(Item item)
    {
        string tag = item.Data.EquipSlot.ToString();
        if (SlotByEquipPlace[tag].GroupBy(slot => slot.Item == null).Any(group => group.Count() > 0))
        {
            SlotByEquipPlace[tag].First(slot => slot == null).Item = item;
        }
        else
        {
            Debug.Log("�κ��丮�� �� á���ϴ�.");
        }
    }

    public void RemoveItem(Item item)
    {
        SlotByEquipPlace[item.Data.EquipSlot.ToString()].First(slot => slot.Item == item).Item = null;
    }
}
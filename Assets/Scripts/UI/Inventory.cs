using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Queue<Slot> Slots;
    public Dictionary<string,Queue<Slot>> SlotByEquipPlace;


    private void Awake()
    {
        SlotByEquipPlace = new Dictionary<string, Queue<Slot>>();
        Slots = new Queue<Slot>();
        Slot[] slots = GetComponentsInChildren<Slot>();
        for (int i = 0; i < slots.Length; i++)
        {
            Slots.Enqueue(slots[i]);
        }
    }

    private void Start()
    {
        foreach (Slot slot in Slots)
        {
            Debug.Log(slot);
        }
    }


}
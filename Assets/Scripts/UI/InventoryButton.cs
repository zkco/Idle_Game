using System;
using UnityEngine;

// 인벤토리 내부의 버튼을 누르면 해당 아이템을 Equipment로 전달
public class InventoryButton : MonoBehaviour
{
    public Slot slot;
    public EquipmentSlot[] _equipSlot;

    private void Awake()
    {
        slot = GetComponentInParent<Slot>();
    }

    private void Start()
    {
        _equipSlot = ItemManager.Instance.Equipment.GetComponentsInChildren<EquipmentSlot>();
    }

    public void EquipItem()
    {
        if (ItemManager.Instance.Inventory.SellMode == true)
        {
            ItemManager.Instance.Inventory.RemoveItem(slot);
        }
        else
        {
            if (slot.Item != null)
            {
                slot.Item.IsEquiped = true;
                slot.IconChange();
            }
            else return;

            if (_equipSlot == null)
            {
                _equipSlot = ItemManager.Instance.Equipment.Slots;
            }
            for (int i = 0; i < _equipSlot.Length; i++)
            {
                if (_equipSlot[i].EquipSlot == slot.Item.Data.EquipSlot)
                {
                    _equipSlot[i].Item = slot.Item;
                    _equipSlot[i].Item.IsEquiped = true;
                    _equipSlot[i].IconChange();
                }
            }
        }
    }

    //public void UnEquipOther()
    //{
    //    Slot[] slots = ItemManager.Instance.Equipment.Slots;
    //    foreach (Slot slot in InventoryQueue)
    //    {
    //        for (int i = 0; i < slots.Length; i++)
    //        {
    //            if (slots[i] != slot)
    //            {
    //                slot.EquipIcon.gameObject.SetActive(false);
    //                slot.EquipText.gameObject.SetActive(false);
    //            }
    //            else continue;
    //        }
    //    }
    //}
}
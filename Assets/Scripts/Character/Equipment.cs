using UnityEngine;

public class Equipment : MonoBehaviour
{
    public EquipmentSlot[] Slots;

    private void Awake()
    {
        Slots = GetComponentsInChildren<EquipmentSlot>();
        ItemManager.Instance.Equipment = this;
    }

    public int AddStatus()
    {
        int status = 0;
        for (int i = 0; i < Slots.Length; i++)
        {
            if (Slots[i].Item == null) continue;
            status += Slots[i].Item.Data.Status;
        }
        return status;
    }
}
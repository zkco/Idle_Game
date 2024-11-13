using UnityEngine;

//Equipmentâ�� ������ Ŭ�� �� �ش� tag�� ���� ������ â�� ȣ��
public class EquipmentButton : MonoBehaviour
{
    public EquipSlot EquipSlot;
    public GameObject Inventory;
    public Slot slot;

    private void Awake()
    {
        slot = GetComponentInParent<Slot>();
    }

    private void Start()
    {
        Inventory = ItemManager.Instance.Inventory.gameObject;
    }

    public void CallInventory()
    {
        if(Inventory.activeSelf == false) Inventory.SetActive(true);
        ItemManager.Instance.Inventory.ShowInventory();
    }
}
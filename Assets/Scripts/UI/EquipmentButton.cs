using UnityEngine;

//Equipmentâ�� ������ Ŭ�� �� �ش� tag�� ���� ������ â�� ȣ��
public class EquipmentButton : MonoBehaviour
{
    public EquipSlot EquipSlot;
    public GameObject Inventory;

    private void Awake()
    {
        Inventory = ItemManager.Instance.Inventory.gameObject;
    }

    public void CallInventory()
    {
        if(Inventory.activeSelf == false) Inventory.SetActive(true);
        ItemManager.Instance.Inventory.ShowInventory();
    }
}
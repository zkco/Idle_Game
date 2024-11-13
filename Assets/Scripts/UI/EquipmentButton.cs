using UnityEngine;

//Equipment창의 슬롯을 클릭 시 해당 tag를 가진 아이템 창을 호출
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
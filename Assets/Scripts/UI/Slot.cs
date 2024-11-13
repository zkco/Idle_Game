using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item Item;
    public TextMeshProUGUI EquipText;
    public Image EquipIcon;

    protected void Awake()
    {
        if (Item == null)
        {
            EquipText.gameObject.SetActive(false);
            EquipIcon.gameObject.SetActive(false);
        }
        else
        {
            EquipText.gameObject.SetActive(Item.IsEquiped);
            EquipIcon.sprite = Item.SlotImage;
        }
        EquipIcon.gameObject.SetActive(Item != null);
    }

    /// <summary>
    /// 슬롯 이미지를 아이템 이미지로 변경
    /// </summary>
    public void IconChange()
    {
        if(Item != null)
        {
            EquipIcon.gameObject.SetActive(true);
            EquipIcon.sprite = Item.SlotImage;
            EquipText.gameObject.SetActive(Item.IsEquiped);
            return;
        }
        else
        {
            EquipIcon.gameObject.SetActive(false);
            EquipIcon.sprite = null;
            EquipText.gameObject.SetActive(false);
            return;
        }
    }
}

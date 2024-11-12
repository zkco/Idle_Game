using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item Item;
    public TextMeshProUGUI EquipText;
    public Image EquipIcon;

    private void Awake()
    {
        if (Item == null)
        {
            EquipText.gameObject.SetActive(false);
        }
        else
        {
            EquipText.gameObject.SetActive(Item.IsEquiped);
        }
        EquipIcon.gameObject.SetActive(Item != null);
    }
}
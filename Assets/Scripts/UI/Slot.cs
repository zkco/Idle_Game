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
        EquipIcon.gameObject.SetActive(false);
    }
}
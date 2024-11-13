using System;
using UnityEngine;

// 인벤토리 내부의 버튼을 누르면 해당 아이템을 Equipment로 전달
public class InventoryButton : MonoBehaviour
{
    public Slot slot;

    private void Awake()
    {
        slot = GetComponentInParent<Slot>();
    }

    public string OnClick()
    {
        return null;
    }
}
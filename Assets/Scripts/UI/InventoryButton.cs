using System;
using UnityEngine;

// �κ��丮 ������ ��ư�� ������ �ش� �������� Equipment�� ����
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
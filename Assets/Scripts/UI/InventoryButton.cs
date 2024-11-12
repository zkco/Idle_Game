using System;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public event Action Click;
    private GameObject Inventory;

    private void Awake()
    {
        Inventory = GetComponentInParent<Inventory>().gameObject;
    }

    private void Start()
    {

    }

    public void OnClick()
    {
        Click.Invoke();
    }
}
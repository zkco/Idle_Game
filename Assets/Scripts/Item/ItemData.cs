using UnityEngine;
using UnityEngine.UIElements;
public enum EquipSlot
{
    Helmet,
    Armor,
    Weapon,
    Shoes
}

public enum Rairity
{
    Normal,
    Rare,
    Unique
}

[CreateAssetMenu(fileName = "Item", menuName = "ItemData", order = 0)]
public class ItemData : ScriptableObject
{
    public string Name;
    public string Description;
    public Rairity Rairity;
    public EquipSlot EquipSlot;
    public int Status;
    public int Price;
}
using UnityEngine;

public class Equipment : MonoBehaviour
{
    private Slot[] _slots;

    private void Awake()
    {
        _slots = GetComponentsInChildren<Slot>();
        ItemManager.Instance.Equipment = this;
        
    }
    private void Update()
    {
        
    }

    public int AddStatus()
    {
        int status = 0;
        for (int i = 0; i < _slots.Length; i++)
        {
            if (_slots[i].Item == null) continue;
            status += _slots[i].Item.Data.Status;
        }
        return status;
    }
}
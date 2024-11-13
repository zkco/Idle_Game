using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    public Image Gauge;
    public float CurValue;
    public float MaxValue;

    private void Start()
    {
        CurValue = MaxValue;
    }

    public float ReduceValue(float value)
    {
        CurValue -= value;
        return Mathf.Min(CurValue, MaxValue)/MaxValue;
    }

    public float AddValue(float value)
    {
        CurValue += value;
        return Mathf.Max(CurValue, 0)/MaxValue;
    }

    public void SetValue(float value)
    {
        CurValue = value;
    }
}

public class Exp : Condition
{
    
}
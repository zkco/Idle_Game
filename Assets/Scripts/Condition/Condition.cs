using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    public Image Gauge;
    public float CurValue;
    public float MaxValue;

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

    public float SetValue(float value)
    {
        CurValue = value;
        return CurValue/MaxValue;
    }
}
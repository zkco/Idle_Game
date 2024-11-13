using UnityEngine;

public class StageSelector : MonoBehaviour
{
    public int StageIdx;

    public void StageSelect()
    {
        MapManager.Instance.Stage = StageIdx;
    }
}
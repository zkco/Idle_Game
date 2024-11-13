using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCondition : MonoBehaviour
{
    public Condition Hp;
    public Condition Mp;
    public Condition Exp;
    public TextMeshProUGUI Gold;

    private void Update()
    {
        Gold.text = $"Gold : {GameManager.Instance.Character.Gold.ToString()}";
    }

    public void AddGold(int gold)
    {
        GameManager.Instance.Character.Gold += gold ;
    }

    public void RemoveGold(int gold)
    {
        if(GameManager.Instance.Character.Gold - gold >= 0)
        GameManager.Instance.Character.Gold -= gold ;
    }
}
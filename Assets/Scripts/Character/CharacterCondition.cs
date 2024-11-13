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
}
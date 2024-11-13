using UnityEngine;

public class OnOffButton : MonoBehaviour
{
    public GameObject UI;

    public void OnOff()
    {
        if(UI.activeSelf == true) UI.SetActive(false);
        else UI.SetActive(true);
    }
}
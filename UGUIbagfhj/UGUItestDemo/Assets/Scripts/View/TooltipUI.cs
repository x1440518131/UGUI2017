using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TooltipUI : MonoBehaviour {
    public Text OutLineText;
    public Text ContentText;

    public void UpdateTooltip(string text)
    {
        OutLineText.text = text;
        ContentText.text = text;
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void SetLocationPosition(Vector2 position)
    {
        transform.localPosition = position;
    }
}



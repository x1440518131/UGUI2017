using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    public Text ItemName;

    public void UpdateItem(string name)
    {
        ItemName.text = name;
    }
}

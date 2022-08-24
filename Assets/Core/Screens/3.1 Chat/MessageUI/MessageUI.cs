using TMPro;
using UnityEngine;

public class MessageUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _display;

    public void SetText(string text)
    {
        _display.text = text;
    }
}
using TMPro;
using UnityEngine;

public abstract class LinkInitializer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _display;
    [SerializeField] private string _linkName;

    private void Start()
    {
        _display.text = "<link=" + '"' + GetLinkFromXml() + '"' + '>' + _linkName + "</link>";
        Destroy(this);
    }

    public abstract string GetLinkFromXml();
}

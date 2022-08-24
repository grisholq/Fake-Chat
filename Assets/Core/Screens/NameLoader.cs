using TMPro;
using UnityEngine;

public class NameLoader : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _name;

    private void OnEnable()
    {
        LoadName();
    }

    public void LoadName()
    {
        _name.text = Characters.Instance.ChoosenCharacter.Name;
    }
}
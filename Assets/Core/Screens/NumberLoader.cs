using TMPro;
using UnityEngine;

public class NumberLoader : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _number;

    private void OnEnable()
    {
        LoadNumber();
    }

    public void LoadNumber()
    {
        _number.text = Characters.Instance.ChoosenCharacter.Number;
    }
}
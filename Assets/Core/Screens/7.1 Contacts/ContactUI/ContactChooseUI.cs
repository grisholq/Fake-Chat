using UnityEngine;
using UnityEngine.UI;

public class ContactChooseUI : MonoBehaviour
{
    [SerializeField] private Sprite _choosen;
    [SerializeField] private Sprite _notChoosen;

    [SerializeField] private Image _display;

    public Character Character { get; private set; }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void SetCharacter(Character character)
    {
        Character = character;
    }

    public void UpdateUI()
    {
        if(Character.IsChoosen)
        {
            _display.sprite = _choosen;
        }
        else
        {
            _display.sprite = _notChoosen;
        }
    }
}
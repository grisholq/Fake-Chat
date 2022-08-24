using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ContactUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _number;
    [SerializeField] private RawImage _profilePicture;

    [SerializeField] private ContactUnlockStateUI _unlockStateUI;
    [SerializeField] private ContactEvents _events;

    public ContactEvents Events => _events;

    public Character Character { get; private set; }

    public void SetCharacter(Character character)
    {
        Character = character;
        _unlockStateUI.SetCharacter(Character);
    }

    public void UpdateUI()
    {
        SetBasicInformation();
        _unlockStateUI.UpdateUI();
    }

    private void SetBasicInformation()
    {
        _name.text = Character.Name;
        _number.text = Character.Number;
        _profilePicture.texture = Character.ProfilePicture;
    }
}
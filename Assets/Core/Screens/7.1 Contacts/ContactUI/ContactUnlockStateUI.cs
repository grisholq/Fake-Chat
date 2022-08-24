using UnityEngine;

public class ContactUnlockStateUI : MonoBehaviour
{
    [SerializeField] private ContactChooseUI _chooseUI;
    [SerializeField] private ContactAdsLockUI _adsLockUI;

    public Character Character { get; private set; }

    public void SetCharacter(Character character)
    {
        Character = character;
        _chooseUI.SetCharacter(character);
        _adsLockUI.SetCharacter(character);
    }

    public void UpdateUI()
    {
        if(Character.IsUnlocked)
        {
            _chooseUI.Show();
            _chooseUI.UpdateUI();
            _adsLockUI.Hide();
        }
        else
        {
            _adsLockUI.Show();
            _adsLockUI.UpdateUI();
            _chooseUI.Hide();
        }
    }
}
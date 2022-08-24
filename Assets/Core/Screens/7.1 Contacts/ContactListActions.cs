using UnityEngine;
using UnityEngine.Events;

public class ContactListActions : MonoBehaviour
{
    [SerializeField] private ContactUnlockAddPopUp _adPopUp;

    public void ChooseCharacter(ContactUI contact)
    {
        Characters.Instance.ChooseCharacter(contact.Character);
    }

    public void OpenAdsWatchScreen(ContactUI contact)
    {
        _adPopUp.SetCharacter(contact.Character);
        _adPopUp.Show();
    }

    public void AddWatchedToCharacters()
    {
        Characters.Instance.AddWatchToCharacters();
    }

    public void WatchAd()
    {
        RewardAdShower.Instance.ShowAd();
    }

    public void ChooseCharacter(Character character)
    {
        Characters.Instance.ChooseCharacter(character);
    }
}

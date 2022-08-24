using UnityEngine;

public class ContactListEventsInitializer : MonoBehaviour
{
    [SerializeField] private ContactsList _contacts;
    [SerializeField] private ContactListActions _actions;

    public void InitializeEvents()
    {
        foreach (var contact in _contacts.Contacts)
        {
            contact.Events.ChooseButtonPressed += _actions.ChooseCharacter;
            contact.Events.UnlockAdsButtonPressed += _actions.OpenAdsWatchScreen;
        }
    }
}
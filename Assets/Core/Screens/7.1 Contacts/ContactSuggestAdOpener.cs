using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactSuggestAdOpener : MonoBehaviour
{
    [SerializeField] private ContactsListInitializer _contactsInitializer;
    [SerializeField] private ContactsList _contacts;
    [SerializeField] private ContactListActions _actions;

    private Character _character;

    public void OpenUnlockAdForContactByCharacter(Character character)
    {
        _character = character;

        if(_contactsInitializer.Initialized)
        {
            ContactUI contact = GetContactByCharacter(character);
            _actions.OpenAdsWatchScreen(contact);
        }
        else
        {
            _contactsInitializer.ContactsInitialized += () => 
            {
                ContactUI contact = GetContactByCharacter(character);
                _actions.OpenAdsWatchScreen(contact);
            };
        }
        
    }

    private ContactUI GetContactByCharacter(Character character)
    {
        foreach (var contact in _contacts.Contacts)
        {
            if (contact.Character == character)
            {
                return contact;
            }
        }

        return null;
    }
}
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ContactsListUIInitializer : MonoBehaviour
{
    [SerializeField] private ContactsList _contacts;
    [SerializeField] private ContactUI _characterUIPrefab;
    [SerializeField] private Transform _contactsParent;

    public void InitializeUI()
    {
        List<Character> characters = Characters.Instance.CharactersList;
        Debug.Log(characters.Count);
        foreach (var character in characters)
        {
            ContactUI contact = InstantiateContactUI();
            contact.SetCharacter(character);
            contact.UpdateUI();
            
        }

        _contacts.Contacts = GetComponentsInChildren<ContactUI>();

        FilterContactsByWatches();
    }

    private void FilterContactsByWatches()
    {
        List<ContactUI> contactUIs = new List<ContactUI>(_contacts.Contacts);
        contactUIs.Sort(new ContactsComparer());

        foreach (var contact in contactUIs)
        {
            if (contact.Character.IsUnlocked)
            {
                contact.transform.SetAsFirstSibling();
                continue;
            }
            contact.transform.SetAsLastSibling();
        }
    }

    private ContactUI InstantiateContactUI()
    {
        return Instantiate(_characterUIPrefab.transform, _contactsParent).GetComponent<ContactUI>();
    }
}
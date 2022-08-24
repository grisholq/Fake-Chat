using UnityEngine;

public class ContactsListUpdater : MonoBehaviour
{
    [SerializeField] private ContactsList _contacts;

    private void Update()
    {
        UpdateContactsUI();
    }

    public void UpdateContactsUI()
    {
        foreach (var contact in _contacts.Contacts)
        {
            contact.UpdateUI();
        }
    }
}
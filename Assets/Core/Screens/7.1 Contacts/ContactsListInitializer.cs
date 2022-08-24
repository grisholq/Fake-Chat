using UnityEngine;
using UnityEngine.Events;

public class ContactsListInitializer : MonoBehaviour
{
    [SerializeField] private ContactsListUIInitializer _contactsUIInit;
    [SerializeField] private ContactListEventsInitializer _contactsEventsInit;

    public event UnityAction ContactsInitialized;

    public bool Initialized = false;

    private void Start()
    {
        if (Initialized) return;
        _contactsUIInit.InitializeUI();
        _contactsEventsInit.InitializeEvents();
        if(ContactsInitialized != null) ContactsInitialized();
        Initialized = true;
    }
}

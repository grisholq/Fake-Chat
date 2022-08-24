using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ContactEvents : MonoBehaviour
{
    [SerializeField] private ContactUI _contactUI;

    public event UnityAction<ContactUI> ChooseButtonPressed; 
    public event UnityAction<ContactUI> UnlockAdsButtonPressed; 

    public void CallChooseButtonPressedEvent()
    {
        ChooseButtonPressed(_contactUI);
    }

    public void CallUnlockAdsButtonPressedEvent()
    {
        UnlockAdsButtonPressed(_contactUI);
    }
}

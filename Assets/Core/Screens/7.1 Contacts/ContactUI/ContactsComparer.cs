using System.Collections.Generic;

public class ContactsComparer : IComparer<ContactUI>
{
    public int Compare(ContactUI first, ContactUI second)
    {
        if (first.Character.AdsToOpen > second.Character.AdsToOpen) return 1;
        else if (first.Character.AdsToOpen < second.Character.AdsToOpen) return -1;
        return 0;
    }
}
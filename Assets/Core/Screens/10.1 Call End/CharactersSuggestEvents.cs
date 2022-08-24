using UnityEngine;
using UnityEngine.Events;

public class CharactersSuggestEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent<Character> LockedCharacterPressed;
    [SerializeField] private UnityEvent<Character> UnlockedCharacterPressed;

    public void CallLockedCharacterPressed(Character character)
    {
        LockedCharacterPressed.Invoke(character);
    }
    
    public void CallUnlockedCharacterPressed(Character character)
    {
        UnlockedCharacterPressed.Invoke(character);
    }
}

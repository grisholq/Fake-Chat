using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CharacterSaver
{
    public static void SaveCharacter(Character character)
    {
        SaveUnlockState(character);
        SaveChoosenState(character);
        SaveWatchedAds(character);
        SaveMessagesHistory(character);
        PlayerPrefsUtility.SaveAllData();
    }

    private static void SaveUnlockState(Character character)
    {
        string key = character.Name + CharacterKeys.UnlockKey;
        PlayerPrefsUtility.SaveBool(key, character.IsUnlocked);
    }

    private static void SaveChoosenState(Character character)
    {
        string key = character.Name + CharacterKeys.UnlockKey;
        PlayerPrefsUtility.SaveBool(key, character.IsUnlocked);
    }
    
    private static void SaveWatchedAds(Character character)
    {
        string key = character.Name + CharacterKeys.AdsKey;
        PlayerPrefsUtility.SaveInt(key, character.WatchedAdds);
    }
    
    private static void SaveMessagesHistory(Character character)
    {
        string amountKey = character.Name + CharacterKeys.MessagesAmount;
        string messageKey = character.Name + CharacterKeys.MessageIdBase;
        PlayerPrefsUtility.SaveListInt(amountKey, messageKey, character.MessagesHistory);
    }
}

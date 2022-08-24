public static class CharacterLoader
{
    public static void LoadCharacter(Character character)
    {
        LoadUnlockState(character);
        LoadChoosenState(character);
        LoadWatchedAds(character);
        LoadMessageHistory(character);
    }

    private static void LoadUnlockState(Character character)
    {
        string key = GetCharacterBasicKey(character) + CharacterKeys.UnlockKey;
        character.IsUnlocked = PlayerPrefsUtility.LoadBool(key, character.IsUnlocked);
    }
    
    private static void LoadChoosenState(Character character)
    {
        string key = GetCharacterBasicKey(character) + CharacterKeys.ChoosenKey;
        character.IsChoosen = PlayerPrefsUtility.LoadBool(key, character.IsChoosen);
    } 
    
    private static void LoadWatchedAds(Character character)
    {
        string key = GetCharacterBasicKey(character) + CharacterKeys.AdsKey;
        character.WatchedAdds = PlayerPrefsUtility.LoadInt(key, character.WatchedAdds);
    }

    private static void LoadMessageHistory(Character character)
    {
        string amountKey = GetCharacterBasicKey(character) + CharacterKeys.MessagesAmount;
        string messageKey = GetCharacterBasicKey(character) + CharacterKeys.MessageIdBase;

        character.MessagesHistory = PlayerPrefsUtility.LoadListInt(amountKey, messageKey, character.MessagesHistory);
    }

    private static string GetCharacterBasicKey(Character character)
    {
        return character.Name;
    }
}
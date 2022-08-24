using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class Characters : Singleton<Characters>
{
    public List<Character> CharactersList;

    [HideInInspector] public Character ChoosenCharacter;

    private void Awake()
    {
        InitializeCharacters();
        InitializeChoosenCharacter();
    }

    private void OnApplicationPause(bool pause)
    {
        foreach (var character in CharactersList)
        {
            CharacterSaver.SaveCharacter(character);
        }
    }

    private void InitializeCharacters()
    {
        foreach (var character in CharactersList)
        {
            CharacterLoader.LoadCharacter(character);
        }
    }

    private void InitializeChoosenCharacter()
    {
        foreach (var character in CharactersList)
        {
            if (character.IsChoosen) ChoosenCharacter = character;
        }
    }

    public void ChooseCharacter(Character character)
    {
        ChoosenCharacter.IsChoosen = false;
        ChoosenCharacter = character;
        ChoosenCharacter.IsChoosen = true;
    }

    public void AddWatchToCharacters()
    {
        foreach (var character in CharactersList)
        {
            if (character.IsUnlocked) continue;

            character.WatchedAdds++;

            if (character.WatchedAdds >= character.AdsToOpen)
            {
                character.IsUnlocked = true;
            }
        }    
    }
    
    public void ResetChoosenCharacterChat()
    {
        ChoosenCharacter.MessagesHistory = new List<int>();
    }
}
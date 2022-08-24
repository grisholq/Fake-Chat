using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosenCharacter : Singleton<ChoosenCharacter>
{
    public Character Character { get; private set; }

    public void InitializeCurrentCharacter()
    {
        Character[] characters = Characters.Instance.CharactersList.ToArray();

        foreach (var character in characters)
        {
            if(character.IsChoosen)
            {
                SetCurrentCharacter(character);
                Debug.Log(character.Name);
                return;
            }
        }
    }

    public void SetCurrentCharacter(Character character)
    {
        Character = character;
    }
}
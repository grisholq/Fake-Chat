using System.Collections.Generic;
using UnityEngine;

public class CharactersSuggestShower : MonoBehaviour
{
    [SerializeField] private CharactersSuggestEvents _events;

    [SerializeField] private CharacterSuggestUI _suggestPrefab;
    [SerializeField] private Transform _parent;

    private const int _maxSuggestAmount = 4;

    private void OnEnable()
    {
        ShowSuggest();
    }

    private void OnDisable()
    {
        ClearSuggest();
    }

    private void ShowSuggest()
    {
        Character[] characters = GetCharacters();

        for (int i = 0; i < characters.Length; i++)
        {
            CharacterSuggestUI suggestUI = InstantiateSuggestUI();
            suggestUI.SetImage(characters[i].ProfilePicture);
            suggestUI.Character = characters[i];

            if (characters[i].IsUnlocked)
            {
                suggestUI.CharacterSuggestPressed += _events.CallUnlockedCharacterPressed;
            }
            else
            {
                suggestUI.CharacterSuggestPressed += _events.CallLockedCharacterPressed;
            }
        }
    }

    private void ClearSuggest()
    {
        for (int i = 0; i < _parent.childCount; i++)
        {
            Destroy(_parent.GetChild(i).gameObject);
        }
    }

    private CharacterSuggestUI InstantiateSuggestUI()
    {
        return Instantiate(_suggestPrefab, _parent);
    }

    private Character[] GetCharacters()
    {
        List<Character> characters = Characters.Instance.CharactersList;

        while(characters.Count > _maxSuggestAmount)
        {
            int index = Random.Range(0, characters.Count);
            characters.RemoveAt(index);
        }

        return characters.ToArray();
    }
}
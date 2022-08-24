using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CharacterSuggestUI : MonoBehaviour
{
    [SerializeField] private RawImage _image;

    public event UnityAction<Character> CharacterSuggestPressed;

    public Character Character { get; set; }

    public void SetImage(Texture texture)
    {
        _image.texture = texture;
    }

    public void PressCharacterSuggest()
    {
        CharacterSuggestPressed.Invoke(Character);
    }
}
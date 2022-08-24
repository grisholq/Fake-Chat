using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfilePictureLoader : MonoBehaviour
{
    [SerializeField] private RawImage _rawImage;

    private void OnEnable()
    {
        LoadProfilePicture();
    }

    public void LoadProfilePicture()
    {
        _rawImage.texture = Characters.Instance.ChoosenCharacter.ProfilePicture;
    }
}

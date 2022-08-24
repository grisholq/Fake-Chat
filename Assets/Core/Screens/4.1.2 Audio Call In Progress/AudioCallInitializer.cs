using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCallInitializer : MonoBehaviour
{
    [SerializeField] private AudioSource _source;

    private void OnEnable()
    {
        _source.clip = Characters.Instance.ChoosenCharacter.CallAnwser;
        _source.Play();
    }
}
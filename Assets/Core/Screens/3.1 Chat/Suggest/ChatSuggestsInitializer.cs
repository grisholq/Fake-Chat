using UnityEngine;
using System.Collections.Generic;

public class ChatSuggestsInitializer : MonoBehaviour
{
    [SerializeField] private ChatSuggestUIInitializer _suggestUIInitializer;
    [SerializeField] private ChatSuggestEventsInitializer _eventsInitializer;

    private bool _initialized = false; 

    public void Awake()
    {
        if (_initialized) return;

        _suggestUIInitializer.InitializeUI();
        _eventsInitializer.InitializeEvents();

        _initialized = true;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveStreamMessagesGenerator : MonoBehaviour
{
    [SerializeField] private Transform _messagesParent;
    [SerializeField] private LiveStreamMessageUI _messagePrefab;
    [SerializeField] private float _messageGenerationTime;
    [SerializeField] private int _maxMessagesAmount;

    private float _passedTime;

    private void OnEnable()
    {
        _passedTime = 0;
    }

    private void OnDisable()
    {
        ClearAllMessages();
    }

    private void Update()
    {
        TickTime();

        if (TimePassed())
        {
            GenerateRandomLiveMessage();
            ResetTime();
        }

        if(IsEnoughMessages() == false)
        {
            DeleteFirstMessage();
        }
    }

    private void ClearAllMessages()
    {
        for (int i = 0; i < _messagesParent.childCount; i++)
        {
            Destroy(_messagesParent.GetChild(i).gameObject);
        }
    }

    private void TickTime()
    {
        _passedTime += Time.deltaTime;
    }

    private bool TimePassed()
    {
        return _passedTime >= _messageGenerationTime;
    }

    private void ResetTime()
    {
        _passedTime = 0;
    }

    private void GenerateRandomLiveMessage()
    {
        LiveStreamMessageUI message = InstantiateLiveMessage();

        Character[] characters = Characters.Instance.CharactersList.ToArray();
        int index = Random.Range(0, characters.Length);

        message.PrepareMessage(characters[index]);
    }

    private LiveStreamMessageUI InstantiateLiveMessage()
    {
        return Instantiate(_messagePrefab, _messagesParent);
    }

    private bool IsEnoughMessages()
    {
        return _messagesParent.childCount <= _maxMessagesAmount;
    }

    public void DeleteFirstMessage()
    {
        Destroy(_messagesParent.GetChild(0).gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CharacterChatUtility
{
    public static List<ChatMessage> GetChatHistory(Character character)
    {
        List<int> messageHistory = character.MessagesHistory;
        List<ChatMessage> chatMessages = new List<ChatMessage>();

        foreach (var id in messageHistory)
        {
            chatMessages.Add(GetChatMessageById(character, id));
        }

        return chatMessages;
    }

    public static ChatMessage GetChatMessageById(Character character, int id)
    {
        ChatMessage[] messages = character.ChatMessages;

        foreach (var message in messages)
        {
            if (message.Id == id) return message;
        }

        return null;
    }
}

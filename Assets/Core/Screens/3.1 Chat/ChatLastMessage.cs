using UnityEngine;

public class ChatLastMessage : MonoBehaviour
{
    public ChatMessage Message { get; set; }

    public MyMessageUI Question { get; set; }
    public OtherMessageUI Anwser { get; set; }

    public void ShowQuestion()
    {
        Question.gameObject.SetActive(true);
    }

    public void ShowAnwser()
    {
        Anwser.gameObject.SetActive(true);
    }

    public void HideQuestion()
    {
        Question.gameObject.SetActive(false);
    }
    
    public void HideAnwser()
    {
        Anwser.gameObject.SetActive(false);
    }
}
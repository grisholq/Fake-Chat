using UnityEngine;

public class MyMessageUI : MessageUI
{
    private void OnEnable()
    {
        Canvas.ForceUpdateCanvases();
    }
}
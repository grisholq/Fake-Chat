using UnityEngine;

public class OtherMessageUI : MessageUI
{
    private void OnEnable()
    {
        Canvas.ForceUpdateCanvases();
    }
}
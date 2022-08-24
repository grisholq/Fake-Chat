using UnityEngine;

public class PrivacyLinkButton : MonoBehaviour
{
    public void OpenPrivacyLink()
    {
        Application.OpenURL(StringsMono.Strings.Privacy);
    }
}
using UnityEngine;

public class RateUsButton : MonoBehaviour
{
    public void OpenGooglePlayPage()
    {
        Application.OpenURL(StringsMono.Strings.GooglePlayPage);
    }
}
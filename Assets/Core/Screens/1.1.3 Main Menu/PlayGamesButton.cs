using UnityEngine;

public class PlayGamesButton : MonoBehaviour
{
    public void OpenGamesLink()
    {
        WebView webView = WebView.Instance;

        webView.SetUrl(StringsMono.Strings.Games);
        webView.IsActive = true;
        StartCoroutine(webView.ShowWebView());
    }
}
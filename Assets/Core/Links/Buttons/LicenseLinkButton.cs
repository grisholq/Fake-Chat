using UnityEngine;

public class LicenseLinkButton : MonoBehaviour
{
    public void OpenLicenseLink()
    {
        Application.OpenURL(StringsMono.Strings.License);
    }
}
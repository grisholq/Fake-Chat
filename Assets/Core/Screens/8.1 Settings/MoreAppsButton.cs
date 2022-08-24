using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreAppsButton : MonoBehaviour
{
    public void OpenDeveloperPage()
    {
        Application.OpenURL(StringsMono.Strings.DeveloperPage);
    }
}

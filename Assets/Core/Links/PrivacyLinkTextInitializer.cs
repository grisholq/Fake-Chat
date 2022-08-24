using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivacyLinkTextInitializer : LinkInitializer
{
    public override string GetLinkFromXml()
    {
        return StringsMono.Strings.Privacy;
    }
}
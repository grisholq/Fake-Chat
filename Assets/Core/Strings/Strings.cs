using System.Xml.Serialization;
using UnityEngine;

[XmlRoot("data")]
public class Strings
{
    private TextAsset _stringsSource;

    [XmlElement("privacy")]
    public string Privacy;
    
    [XmlElement("games")]
    public string Games;
    
    [XmlElement("license")]
    public string License;

    [XmlElement("googlePlayDeveloper")]
    public string DeveloperPage;
    
    [XmlElement("googlePlayPage")]
    public string GooglePlayPage;
}
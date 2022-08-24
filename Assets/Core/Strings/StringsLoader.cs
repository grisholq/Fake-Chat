using UnityEngine;
using System.Xml.Serialization;
using System.IO;

public static class StringsLoader
{
    public static Strings Load(TextAsset textAsset)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Strings));
        StringReader reader = new StringReader(textAsset.text);
        Strings strings = serializer.Deserialize(reader) as Strings;
        return strings;
    }
}
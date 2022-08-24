using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareData : Singleton<ShareData>
{
    [SerializeField] private string _filePath;
    [SerializeField] private string _text;

    public NativeShare GetNativeShare()
    {
        NativeShare share = new NativeShare().SetUrl(StringsMono.Strings.GooglePlayPage).SetText("I am using Fake Call App!");

        if(_filePath != "")
        {
            share.AddFile(_filePath);
        }

        return share;
    }
}
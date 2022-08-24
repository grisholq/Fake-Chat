using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringsMono : MonoBehaviour
{
    [SerializeField] private TextAsset TextAsset;

    public static Strings Strings;

    private void OnEnable()
    {
        Strings = StringsLoader.Load(TextAsset);
    }
}
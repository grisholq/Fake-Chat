using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BannerShowStarter : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Show");
        BannerAdShower.Instance.ShowBanner();
    }
}
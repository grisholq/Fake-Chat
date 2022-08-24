using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareButton : MonoBehaviour
{
    public void Share()
    {
        NativeShare share = ShareData.Instance.GetNativeShare();
        share.Share();
    }
}

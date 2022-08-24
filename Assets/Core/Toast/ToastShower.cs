using ToastPlugin;
using UnityEngine;

public class ToastShower : MonoBehaviour
{
    [SerializeField] private string _toastText;

    public void ShowToast()
    {
        ToastHelper.ShowToast(_toastText);
    }
}

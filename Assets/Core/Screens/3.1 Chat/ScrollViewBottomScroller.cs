using UnityEngine;
using UnityEngine.UI;

public class ScrollViewBottomScroller : MonoBehaviour
{
    [SerializeField] private ScrollRect _scrollRect;

    public void ScrollToBottom()
    {
        Debug.Log(1);
        _scrollRect.verticalNormalizedPosition = 0;
    }
}
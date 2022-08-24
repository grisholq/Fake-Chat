using UnityEngine;

public class SavesReseter : MonoBehaviour
{
    [SerializeField] private bool _reset;

    private void Awake()
    {
        if (_reset == true)
        {
            PlayerPrefs.DeleteAll();
        }
    }
}

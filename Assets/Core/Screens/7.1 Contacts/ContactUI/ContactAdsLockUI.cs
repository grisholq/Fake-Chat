using TMPro;
using UnityEngine;

public class ContactAdsLockUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _numberOfWatches;

    public Character Character { get; private set; }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void SetCharacter(Character character)
    {
        Character = character;
    }

    public void UpdateUI()
    {
        int watched = Character.WatchedAdds;
        int totalWatch = Character.AdsToOpen;
        _numberOfWatches.text = watched.ToString() + '/' + totalWatch.ToString();
    }
}
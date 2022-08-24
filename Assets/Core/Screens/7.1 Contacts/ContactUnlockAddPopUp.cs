using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ContactUnlockAddPopUp : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _wathches;

    public UnityEvent<Character> CharacterUnlocked;

    public Character Character { get; private set; }

    private void OnEnable()
    {
        UpdateVideoWatches();
    }

    private void Update()
    {
        if (Character == null) return;

        if (Character.IsUnlocked)
        {
            CharacterUnlocked.Invoke(Character);
            Hide();
        }

        UpdateVideoWatches();
    }

    public void SetCharacter(Character character)
    {
        Character = character;
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void UpdateVideoWatches()
    {
        _wathches.text = Character.WatchedAdds.ToString() + '/' + Character.AdsToOpen.ToString();
    }
}
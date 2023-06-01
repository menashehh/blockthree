using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Letter : MonoBehaviour
{
    [SerializeField] private Button openButton;
    [SerializeField] private GameObject notification;

    [Header("LetterContent")]
    [SerializeField] private TMP_Text title;
    [SerializeField] private TMP_Text date;
    [SerializeField] private Image picture;

    private LetterContent letterContent;
    private bool openedLetter;

    public LetterContent LetterContent => letterContent;

    public event Action<Letter> LetterOpenedEvent;

    private void OnEnable()
    {
        openButton.onClick.AddListener(OnOpenedLetter);
    }

    private void OnDisable()
    {
        openButton.onClick.RemoveListener(OnOpenedLetter);
    }

    private void OnOpenedLetter()
    {
        LetterOpenedEvent?.Invoke(this);
        notification.SetActive(false);
    }

    public void SetLetterContents(LetterContent newLetterContent)
    {
        letterContent = newLetterContent;
        title.text = newLetterContent.Title;
        date.text = newLetterContent.Date;
        picture.sprite = newLetterContent.Picture;
    }

    public void EnableOpenButton()
    {
        openButton.enabled = true;
    }

    public void DisableOpenButton()
    {
        openButton.enabled = false;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class MailboxManager : MonoBehaviour
{
    [SerializeField] private List<Letter> receivedLetters;
    [SerializeField] private GameObject letterPrefab;
    [SerializeField] private Transform letterParent;
    [SerializeField] private GameObject currentLetterObject;

    [SerializeField] private Button closeLetterButton;
    [SerializeField] private Button deleteAllButton;

    [Header("Current Letter Content")]
    [SerializeField] private TMP_Text title;
    [SerializeField] private TMP_Text textContent;
    [SerializeField] private TMP_Text locationPlace;
    [SerializeField] private TMP_Text locationCity;
    [SerializeField] private Button visitPageButton;

    private Letter currentLetter;
    private string linkToPage;

    private void OnEnable()
    {
        deleteAllButton.onClick.AddListener(DeleteAllLetters);
        closeLetterButton.onClick.AddListener(OnCloseCurrentLetter);
        visitPageButton.onClick.AddListener(OnOpenLink);
    }

    private void OnDisable()
    {
        foreach (Letter letter in receivedLetters)
        {
            letter.LetterOpenedEvent -= OnOpenedLetter;
        }

        deleteAllButton.onClick.RemoveListener(DeleteAllLetters);
        closeLetterButton.onClick.RemoveListener(OnCloseCurrentLetter);
        visitPageButton.onClick.RemoveListener(OnOpenLink);
    }

    private void OnCloseCurrentLetter()
    {
        currentLetter = null;
        currentLetterObject.SetActive(false);

        foreach (Letter letter in receivedLetters)
        {
            letter.EnableOpenButton();
        }
    }

    private void OnOpenLink()
    {
        Application.OpenURL(linkToPage);
    }

    public void ReceiveNewLetter(LetterContent letterContent)
    {
        Letter newLetter = Instantiate(letterPrefab, letterParent).GetComponent<Letter>();
        newLetter.SetLetterContents(letterContent);
        receivedLetters.Add(newLetter);

        if (currentLetter != null)
        {
            newLetter.DisableOpenButton();
        }

        newLetter.LetterOpenedEvent += OnOpenedLetter;
    }

    private void OnOpenedLetter(Letter newLetter)
    {
        if (currentLetterObject.activeSelf)
        {
            return;
        }

        currentLetter = newLetter;

        foreach (Letter letter in receivedLetters)
        {
            if (letter != currentLetter)
            {
                letter.DisableOpenButton();
            }
        }

        title.text = newLetter.LetterContent.Title;
        textContent.text = newLetter.LetterContent.TextContent;
        locationPlace.text = newLetter.LetterContent.LocationPlace;
        locationCity.text = newLetter.LetterContent.LocationCity;
        linkToPage = newLetter.LetterContent.LinkToPage;

        currentLetterObject.SetActive(true);
    }

    private void DeleteAllLetters()
    {
        receivedLetters.Clear();

        foreach (Transform letter in letterParent)
        {
            if (letter == null)
            {
                continue;
            }

            letter.GetComponent<Letter>().LetterOpenedEvent -= OnOpenedLetter;
            Destroy(letter.gameObject);
        }
    }
}

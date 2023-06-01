using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LetterSpawner : MonoBehaviour
{
    [SerializeField] private MailboxManager mailboxManager;
    [SerializeField] private int secondsInBetweenSpawns;
    [SerializeField] private List<LetterContent> allLetters;

    private void Awake()
    {
        InvokeRepeating(nameof(SpawnLetter), 0f, secondsInBetweenSpawns);
    }

    private void SpawnLetter()
    {
        LetterContent randomLetter = allLetters[Random.Range(0, allLetters.Count)];
        mailboxManager.ReceiveNewLetter(randomLetter);
    }
}

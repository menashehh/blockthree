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

    private int letterSpawnCount = 0;

    private void SpawnLetter()
    {
        if (letterSpawnCount >= 3)
        {
            CancelInvoke(nameof(SpawnLetter));
            return;
        }

        LetterContent randomLetter = allLetters[Random.Range(0, allLetters.Count)];
        mailboxManager.ReceiveNewLetter(randomLetter);

        letterSpawnCount++;
    }
}

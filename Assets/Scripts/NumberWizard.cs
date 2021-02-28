using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Use this for initialization
    private void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        NextGuess();
    }

    public void onPressHigher()
    {
        if(guess + 1 > max)
        {
            min = max;
        } else
        {
            min = guess + 1;
        }
        NextGuess();
    }

    public void onPressLower()
    {
        if(guess -1 < min)
        {
            max = min;
        } else
        {
            max = guess - 1;
        }
        NextGuess();
    }

    private void NextGuess()
    {
        guess = UnityEngine.Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}

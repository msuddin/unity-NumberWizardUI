using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizardLogic : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    [SerializeField] TextMeshProUGUI randomStatementText;
    
    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
        max += 1;
    }

    public void OnHighButtonPress()
    {
        min = guess;
        CalculateGuess();
    }

    public void OnLowButtonPress()
    {
        max = guess;
        CalculateGuess();
    }

    void CalculateGuess()
    {
        RandomeGuessStatement();
        guess = ((max + min) / 2);
        guessText.text = guess.ToString();
    }

    void RandomeGuessStatement()
    {
        int randomNumber = Random.Range(1, 5);

        if (randomNumber == 1)
        {
            randomStatementText.text = "I am getting a little tense";
        }
        if (randomNumber == 2)
        {
            randomStatementText.text = "Getting warmer.....";
        }
        if (randomNumber == 3)
        {
            randomStatementText.text = "Hopefully not to far off";
        }
        if (randomNumber == 4)
        {
            randomStatementText.text = "Almost there, I can feel it in my bits";
        }
    }
}
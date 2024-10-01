using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numbers : MonoBehaviour
{
    int Guess = 50;
    int max = 100;
    int min = 0;
    int attempts = 0;
    int maxattempts = 5;
    int randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(min, max + 1);
        Debug.Log("Random number generated: " + randomNumber);
        StartGame();
        NextGeuss();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Lower();
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Higher();
        }
        else if (Input.GetKeyUp(KeyCode.Return))
        {
            Enter();
        }
    }
    void StartGame()
    {
        Debug.Log("Welcome to number Guessing game");
        Debug.Log("Pick a number randomly out of your mind, But Don't spit it out!");

        Debug.Log("The highest number you can pick  is: " + max);
        Debug.Log("The lowest number you can pick  is: " + min);


    }

    void NextGeuss()
    {
        Debug.Log("Is the number Higher or Lower than " + Guess + "?");
        Debug.Log("Press Up = Higher , Press Down = Lower , Press Enter = Good Geuss!");


    }
    void Higher()
    {
        if (attempts < maxattempts)
        {
            min = Guess + 1;
            Guess = (max + min) / 2;
            NextGeuss();
            attempts++;
        }
        else
        {
            Debug.Log("Max attempts reached!!!");
        }
    }
    void Lower()
    {
        if (attempts < maxattempts)
        {
            max = Guess - 1;
            Guess = (min + max) / 2;
            NextGeuss();
            attempts++;
        }
        else
        {
            Debug.Log("Max attempts reached!");
        }
    }
    void Enter()
    {
        Debug.Log("You think the number is " + Guess);

        if (Guess == 50)

        {
            Debug.Log("Thanks for playing! you got a good huntch! you had the number!");
        }
        else
        {
            Debug.Log("Sorry, you didn't get it right.");
        }
    }

}

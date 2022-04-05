using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumber : MonoBehaviour
{

    //Variables
    int max;
    int min;
    int guess;
    int guesses;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        //Variables updated for game
        max = 1000;
        min = 1;
        guess = 500;

        //Console log to show the game progression and play
        Debug.Log("Welcome . . . to the Magic Number!");
        Debug.Log("Do you believe that a mere program such as I can read your mind?");
        Debug.Log("I'm going to prove to you that I can!");
        Debug.Log("Pick a number between " + max + " and " + min + "!");
        Debug.Log("Don't tell me what it is though! That's the fun!");
        Debug.Log("Is your number Higher or lower than: " + guess + "?");
        Debug.Log("Push up = Higher, Push down = Lower, Push Enter = Correct");

        //Make max available to divide for odd number guesses
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Input functions for game play
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            Debug.Log("I'll need to guess lower then.");
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            Debug.Log("I'll need to guess higher then.");
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I told you I could read your mind!");
            Debug.Log("Well, after a few tries, at least. . .");
            Debug.Log("I got it right in " + guesses + " tries.");
            Debug.Log("***************************************");
            StartGame();
        }
        else
        {
            Debug.Log("Sorry, that is not an accepted input. Try again.");
        }
    }

    //NextGuess function, to declutter StartGame function
    void NextGuess()
    {
        guesses++;
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than: " + guess + "?");
    }
}

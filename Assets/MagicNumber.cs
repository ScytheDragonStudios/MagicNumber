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
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome . . . to the Magic Number!");
        Debug.Log("Do you believe that a mere program such as I can read your mind?");
        Debug.Log("I'm going to prove to you that I can!");
        Debug.Log("Pick a number between " + max + " and " + min + "!");
        Debug.Log("Don't tell me what it is though! That's the fun!");
        Debug.Log("Is your number Higher or lower than: " + guess + "?");
        Debug.Log("Push up = Higher, Push down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            guesses++;
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("I'll need to guess lower then.");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            guesses++;
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("I'll need to guess higher then.");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I told you I could read your mind!");
            Debug.Log("Well, after a few tries, at least. . .");
        }
    }
}

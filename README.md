# MagicNumber
C# code for school, and technically the first full Unity game I've made that wasn't a collab

Can a mere computer program guess what number you are thinking? I'm going to try and prove that it can! Pick a number, any number from 1 to 1000 and see how many times
it takes the AI to guess!

I have a few functions I'd like to point out that I used to make this game. Originally, when it was still just a Console Log, I used an Input.GetKeyDown(Key.Code(###) t
get input from the player to move around, as well as a simple If/Else statement to change what is shown in the log. After some updates, I used a button with a onClick function
using a SceneLoader custom program to change what is shown, so players see a "Title", a "Core Game", and then a "Win" screen.

I added a Quit.Application() function so players can quit the game. I put it both at the start, so if you don't want to play, you can exit, and of course at the end, where
once you are done letting a computer guess, you can exit.

I originally added a "guesses" variable that would display how many tries it took the AI to guess your number, but it kept causing a crash, so it was removed in this alpha
build. I may add it back with some updated code another time, for now though this will have to do. 

I chose [SerializeField] in order to edit variables as it was much easier to edit Hard-coded variables in the inspector aspect of Unity rather than have a int max, int min, int guess
that would need to be changed and updated with excess code.

This is built as a standalone PC/Mac/Linux game, and can be played on either with mimimal issue. 

I sincerely hope you enjoy the game, which can be downloaded for free on https://scythedragonstudios.itch.io/magic-number 

Through 4 computer crashes, loss of project files due to failed git pushes, and a massively difficult work schedule, I was able to pull something together that I can be
proud of. I have no regrets on this project, except that I wish I had a better computer.

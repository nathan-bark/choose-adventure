﻿using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            // Continue the story by giving the user two choices:
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.WriteLine("YES or NO?");
            string noiseChoice = Console.ReadLine().ToUpper();

            if(noiseChoice == "NO"){
                Console.WriteLine("Not much of an adventure if we don't leave our room!");
                Console.WriteLine("THE END.");
            } else if(noiseChoice == "YES"){
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
                Console.WriteLine("You walk towards it. Do you open it or knock?");
                Console.WriteLine("OPEN or KNOCK?");
                string doorChoice = Console.ReadLine().ToUpper();

                if(doorChoice == "KNOCK"){
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"");
                    Console.WriteLine("Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                    Console.WriteLine("What's the answer?");
                    string riddleAnswer = Console.ReadLine().ToUpper();

                    if(riddleAnswer == "NOTHING"){
                        Console.WriteLine("The door opens and NOTHING is there.");
                        Console.WriteLine("You turn off the light and run back to your room and lock the door.");
                        Console.WriteLine("THE END.");
                    } else {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.");
                        Console.WriteLine("THE END.");
                    }
                } else if(doorChoice == "OPEN"){
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.WriteLine("Which key will you choose? 1, 2, or 3?");
                    string keyChoice = Console.ReadLine().ToUpper();

                    switch (keyChoice){
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange...");
                            Console.WriteLine("THE END.");
                            break;
                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open.");
                            Console.WriteLine("THE END.");
                            break;
                        case "3":
                            Console.WriteLine("You choose the third key. The door doesn't open.");
                            Console.WriteLine("THE END.");
                            break;
                    }
                }
            }


    }
    }
}




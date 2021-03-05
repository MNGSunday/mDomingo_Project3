/*
Name: Marc Domingo
Student ID: 2346778
Chapman Email: mdomingo@chapman.edu
Course Number and Section: 236-03
Assignment: Project 3
This is my own work, and I did not cheat on this assignment.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The following class simulates the concept of the combination used to unlock the keypad in Unity, and contains methods to get information regarding the combination. 

public class Combination
{
    private List<int> combination;
    private List<int> defaultCombination = new List<int> { 1, 2, 3, 4 };

    public Combination()
    {
        combination = CombinationLoader.Load(defaultCombination); 
    }

    public int GetCombinationDigit(int digitNumber)
    {
        if (digitNumber < 0)
            return 0;

        if (digitNumber >= combination.Count)
            return 0;

        return combination[digitNumber];
    }

    public int GetCombinationLength()
    {
        return combination.Count;
    }
}

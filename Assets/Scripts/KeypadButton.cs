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

// The following class is used primarily by the keypad buttons in Unity, and contains a function that records the value of the button pressed.

public class KeypadButton : MonoBehaviour
{
    public int ButtonValue;
    public Keypad Keypad;

    public void OnClick()
    {
        // print("Clicked " + ButtonValue);
        // Tells the keypad that the button was clicked and record the button's value.
        Keypad.RegisterButtonClick(ButtonValue);
    }
}

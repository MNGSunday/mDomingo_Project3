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
using UnityEngine.UI;

// This class is used to manage the background of the keypad in Unity, and has methods to change the color of he keypad's background and to "remove" the unlock button.

public class KeypadBackground : MonoBehaviour
{
    public GameObject UnlockButton;
    public Image BackgroundImage;

    public void HideUnlockButton()
    {
        UnlockButton.SetActive(false);
    }

    public void ChangeToSuccessColor()
    {
        BackgroundImage.color = Color.green;
    }

    public void ChangeToFailedColor()
    {
        BackgroundImage.color = Color.red;
    }

    public void ChangeToDefaultColor()
    {
        BackgroundImage.color = Color.grey;
    }
}

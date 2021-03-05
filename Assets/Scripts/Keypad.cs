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

// The following program contains the functionality of the keypad in Unity, and methods of how the keypad responds to a correct and incorrect combination.

public class Keypad : MonoBehaviour
{
    public KeypadBackground Background;

    private Combination combination;
    private List<int> buttonsEntered; 
    // Start is called before the first frame update
    void Start()
    {
        combination = new Combination();
        ResetButtonEntries();
    }

    public void ResetButtonEntries()
    {
        buttonsEntered = new List<int>();
    }

    public void RegisterButtonClick(int buttonValue)
    {
        buttonsEntered.Add(buttonValue);
        print(string.Join(", ", buttonsEntered));
    }

    public void TryToUnlock()
    {
        if (IsCorrectCombination())
            Unlock();
        else
            FailToUnlock();

        ResetButtonEntries();
    }

    private bool IsCorrectCombination()
    {
        if (HaveNoButtonsBeenClicked())
            return false;

        if (HaveWrongNumberOfButtonsBeenClicked())
            return false;

        return CheckCombination();
    }

    private bool HaveNoButtonsBeenClicked()
    {
        if (buttonsEntered.Count == 0)
            return true;

        return false;
    }

    private bool HaveWrongNumberOfButtonsBeenClicked()
    {
        if (buttonsEntered.Count == combination.GetCombinationLength())
            return false;

        return true;
    }

    private bool CheckCombination()
    {
        for (int buttonIndex = 0; buttonIndex < buttonsEntered.Count; buttonIndex++)
        {
            if (IsCorrectButton(buttonIndex) == false)
                return false;
        }

        return true;
    }

    private bool IsCorrectButton(int buttonIndex)
    {
        if (IsWrongEntry(buttonIndex))
            return false;

        return true;
    }

    private bool IsWrongEntry(int buttonIndex)
    {
        if (buttonsEntered[buttonIndex] == combination.GetCombinationDigit(buttonIndex))
            return false;

        return true;
    }

    private void Unlock()
    {
        Background.HideUnlockButton();
        Background.ChangeToSuccessColor();
    }

    private void FailToUnlock()
    {
        Background.ChangeToFailedColor();
        StartCoroutine(ResetBackgroundColor());
    }

    private IEnumerator ResetBackgroundColor()
    {
        yield return new WaitForSeconds(0.25f);

        Background.ChangeToDefaultColor();
    }
}

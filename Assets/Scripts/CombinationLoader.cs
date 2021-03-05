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
using System.IO;

// The following class is used to read the combination to unlock the keypad from a file, and creates a default combination file and/or directory if neither exists.

public static class CombinationLoader
{
    private static string combinationFileName = "combination.txt";
    private static string combinationFolderName = "Assets/Text";
    private static string combinationPath
    {
        get
        {
            return (Path.Combine(combinationFolderName, combinationFileName));
        }
    }
    public static List<int> Load(List<int> defaultCombination)
    {
        EnsureFileExists(defaultCombination);
        return ReadCombinationFromFile();
    }

    private static void EnsureFileExists(List<int> defaultCombination)
    {
        if (!File.Exists(combinationPath))
            CreateFile(defaultCombination);
    }

    private static void CreateFile(List<int> defaultCombination)
    {
        EnsureDirectoryExists();

        StreamWriter writer = new StreamWriter(combinationPath);
        foreach (int combinationEntry in defaultCombination)
        {
            writer.WriteLine(combinationEntry);
        }
        writer.Close();
    }

    private static void EnsureDirectoryExists()
    {
        if (!Directory.Exists(combinationFolderName))
            Directory.CreateDirectory(combinationFolderName);
    }

    private static List<int> ReadCombinationFromFile()
    {
        List<int> combination = new List<int>();

        StreamReader reader = new StreamReader(combinationPath);
        string combinationNumber = string.Empty;
        while (  (combinationNumber = reader.ReadLine()) != null)
        {
            int combinationInteger = int.Parse(combinationNumber);
            combination.Add(combinationInteger);
        }
        reader.Close();

        return combination;
    }
}

using System;

public class Solution
{
    public int NumOfStrings(string[] patterns, string word)
    {
        int counter = 0; // Initialize the counter

        foreach (string pattern in patterns)
        {
            if (word.Contains(pattern))  // Check if pattern is a substring of word
            {
                counter++;
            }
        }

        return counter;
    }
}

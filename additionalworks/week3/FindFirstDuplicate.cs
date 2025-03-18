using System;
using System.Collections.Generic;

/// <summary>
/// Find the first letter that appears twice in the given string.
/// </summary>
/// <param name="str">The input string to search for duplicates</param>
/// <returns>The first duplicated letter found, or null if no duplicates exist</returns>
char? FindFirstDuplicate(string str)
{
    // Create a HashSet to track letters we've seen
    HashSet<char> seenLetters = new HashSet<char>();
    
    // Iterate through each character in the string
    foreach (char c in str)
    {
        // Check if the character is a letter
        if (char.IsLetter(c))
        {
            // If we've seen this letter before, it's a duplicate
            if (seenLetters.Contains(c))
            {
                return c;
            }
            // Otherwise, add it to our set of seen letters
            else
            {
                seenLetters.Add(c);
            }
        }
    }
    
    // If we finish the loop without finding duplicates, return null
    return null;
}

// Test cases
string[] testCases = {
    "abcddef",     // Should return 'd'
    "abcddeef",    // Should return 'd'
    "abcdefde",    // Should return 'd'
    "",            // Edge case: empty string
    "abc",         // Edge case: no duplicates
    "aaaaaaaaaa",  // Edge case: all the same letter
    "abB",         // Edge case: case sensitivity (no duplicates since 'b' ≠ 'B')
    "ab2(:~",      // Edge case: non-letter characters
    "nñ"           // Edge case: non-ASCII letters
};

// Run the tests
foreach (string test in testCases)
{
    char? result = FindFirstDuplicate(test);
    Console.WriteLine($"String: '{test}' → First duplicate: {(result.HasValue ? result.ToString() : "null")}");
}
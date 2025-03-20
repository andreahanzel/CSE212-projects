public static class UniqueLetters {
    public static void Run() {
        var test1 = "abcdefghjiklmnopqrstuvwxyz"; // Expect True because all letters unique
        Console.WriteLine(AreUniqueLetters(test1));

        var test2 = "abcdefghjiklanopqrstuvwxyz"; // Expect False because 'a' is repeated
        Console.WriteLine(AreUniqueLetters(test2));

        var test3 = "";
        Console.WriteLine(AreUniqueLetters(test3)); // Expect True because its an empty string
    }

    /// <summary>Determine if there are any duplicate letters in the text provided</summary>
    /// <param name="text">Text to check for duplicate letters</param>
    /// <returns>true if all letters are unique, otherwise false</returns>
    private static bool AreUniqueLetters(string text) {
         // --- UPDATED: Optimized to O(n) using HashSet --- //
        var seenLetters = new HashSet<char>(); // UPDATED: Replaced nested loops with HashSet

        foreach (var letter in text) { // UPDATED: Iterate through each character in the string
            if (seenLetters.Contains(letter)) //UPDATED: Check if letter already exists in the set (O(1) lookup)
                return false; // UPDATED: If duplicate found, return false immediately
            seenLetters.Add(letter); // UPDATED: Otherwise, add the letter to the set
        }

        return true; // UPDATED: If no duplicates were found, return true
    }
}
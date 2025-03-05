public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length) 
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // STEP 1: Creating a plan for solving this problem
        // a. Create a new array of doubles with the size specified by length
        // b. Initialize a loop to fill the array with multiples of 'number'
        // c. For each position i in the array, calculate the value as number * (i+1)
        // d. Return the filled array
        
        // STEP 2: Create a new array of doubles with the specified length
        double[] result = new double[length]; 
        
        // STEP 3: Fill the array with multiples of the number
        for (int i = 0; i < length; i++) // Loop through each position in the array
        {
            // The first multiple is 'number' itself (i.e., number * 1)
            // The second multiple is number * 2, and so on 
            result[i] = number * (i + 1); // i + 1 because the first multiple is at index 0
        }
        
        // STEP 4: Return the completed array
            return result; // Return the array of multiples
        }
        

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // STEP 1: Create a plan for solving this problem
        // a. Determine the effective rotation amount - in case amount > data.Count
        // b. Find the index at which to split the list - splitIndex = data.Count - amount 
        // c. Get the slice of elements that should move to the front - elements from splitIndex to end of list
        // d. Get the slice of elements that should move to the back - elements from start to splitIndex 
        // e. Clear the original list and add the slices in the new order - front slice first, then back slice
        
        // STEP 2: Handle edge cases
        if (data == null || data.Count <= 1 || amount == 0) // If the list is empty or has only one element, or amount is 0
        {

        // Nothing to rotate regarding the list or the amount
            return;
        }
        
        // This ensures the amount is in the valid range - 1 to data.Count
        amount = amount % data.Count; // This handles cases where amount > data.Count
        if (amount == 0) return; // No rotation needed
        
        // STEP 3: Calculate the index at which to split the list
        int splitIndex = data.Count - amount;
        
        // STEP 4: Get the two parts of the list using GetRange
        List<int> rightPart = data.GetRange(splitIndex, amount); // Elements that move to the front
        List<int> leftPart = data.GetRange(0, splitIndex); // Elements that move to the back
        
        // STEP 5: Clear and reconstruct the list in the new order
        data.Clear(); // Remove all elements from the original list to add the new ones
        data.AddRange(rightPart); // Add the right part - it will become the front of the list
        data.AddRange(leftPart); // Add the left part - it will become the back of the list
    }
}
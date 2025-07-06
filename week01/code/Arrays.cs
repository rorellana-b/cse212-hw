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
        double[] multiples = new double[length];//Creating an array of doubles with the specified length.
        for (int i = 0; i < length; i++)//Using loop to fill the array with multiples of the given number.
        {
            multiples[i] = number * (i + 1); //Each element is assigned the value of number multiplied by (i + 1) to get the correct multiple.
        }
        return multiples; //Return the filled array.   
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
        amount = amount % data.Count; // Handle cases where amount is greater to avoid unnecessary rotations

        if (amount == 0) return; // No rotation needed if amount is 0

        // We can use GetRange to split the list into two parts.
        //those methods will return a new list containing the specified range of elements. without modifying the original list and witout using loops.

        List<int> rotatedPart = data.GetRange(data.Count - amount, amount); // using method GetRange to get the last 'amount' elements
        List<int> remainingPart = data.GetRange(0, data.Count - amount);// using method GetRange to get the rest of the elements

        data.Clear(); // Clear the original list to prepare for the new order
        data.AddRange(rotatedPart); // Add the rotated part first
        data.AddRange(remainingPart); // Add the remaining part after the rotated part
    }
}

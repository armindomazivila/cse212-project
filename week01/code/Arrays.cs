using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// 
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // My plan:
        // 1. Create a double array with a size equal to length.
        // 2. Use a for loop to go through each position in the array. 
        // 3. Multiply the given number by multiply starting number
        // by the position in the array plus 1.
        // 4. Store the result in the current position of the array.
        // 5. After the loop is finished, return the array.  

        // Create an array with the requested number of elements.
        double[] result = new double[length];

        //Go through each position in the array. 
        for (int i = 0; i < length; i++)
        {
            // Calculate the multiple and store it the current position.
            result[i] = number * (i + 1);
        }
        // Return the completed array.
        return result;
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
        // My plan:
        // 1. Create a new list to hold the rotated values.
        // 2. Use a for loop to go through each position in the original list.
        // 3. Calculate the new position for each value by adding the amount to the current 
        // index and taking the modulus with the length of the list.
        // 4. Store the value from the original list in the new position in the new list.
        // 5. After the loop is finished, copy the values from the new list back to the original list.

        // Create a new list with the same number of positions as data.
        List<int> rotated = new List<int>(new int[data.Count]);

        //Go through each position in the original list.
        for (int i = 0; i < data.Count; i++)
        {
            // Calculate the new position for the current value to the right.
            int newPosition = (i + amount) % data.Count;

            // Store the value in its new position in the rotated list.
            rotated[newPosition] = data[i];
        }
        // copy the rotated values back to the original list.
        for (int i = 0; i < data.Count; i++)
        {
            data[i] = rotated[i];
        }
    }
}

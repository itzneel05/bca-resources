// Question:
// Write a Java Program which will read a string and rewrite it in the alphabetical Order eg. The word "STRING" should be written a "GINRST".

import java.util.Arrays; // Import the Arrays class for sorting
import java.util.Scanner; // Import the Scanner class for user input

class Basic_StringBuilder_v4 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in); // Create a Scanner object to read input

        System.out.print("Enter a string: "); // Prompt the user for input
        String inputString = scanner.nextLine(); // Read the input string

        char[] charArray = inputString.toCharArray(); // Convert the string to a character array
        Arrays.sort(charArray); // Sort the character array in alphabetical order

        String sortedString = new String(charArray); // Convert the sorted character array back to a string

        System.out.println("Sorted string: " + sortedString); // Display the sorted string

        scanner.close(); // Close the scanner to free up resources
    }
}

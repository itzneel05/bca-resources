// Question
// Develop a program to remove duplicate characters from a string and return the cleaned version.

import java.util.Scanner; // Import the Scanner class for user input

class Basic_String_v2 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in); // Create a Scanner object to read input

        System.out.print("Enter a string: "); // Prompt the user for input
        String inputString = scanner.nextLine(); // Read the input string

        StringBuilder cleanedString = new StringBuilder(); // Create a StringBuilder to store the cleaned string
        boolean[] charPresent = new boolean[256]; // Array to track character presence (ASCII range)

        // Iterate through each character in the input string
        for (char ch : inputString.toCharArray()) {
            if (!charPresent[ch]) { // Check if the character is not already present
                cleanedString.append(ch); // Append the character to the cleaned string
                charPresent[ch] = true; // Mark the character as present
            }
        }

        // Print the cleaned string without duplicates
        System.out.println("Cleaned string: " + cleanedString.toString());

        scanner.close(); // Close the scanner to free up resources
    }
    
}

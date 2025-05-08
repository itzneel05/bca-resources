// Question:
// Accept a sentence and use StringBuffer to delete all spaces and print the result.

import java.util.Scanner; // Import the Scanner class for user input

class Basic_StringBuilder_v2 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in); // Create a Scanner object to read input

        System.out.print("Enter a sentence: "); // Prompt the user for input
        String inputString = scanner.nextLine(); // Read the input string

        StringBuilder stringBuilder = new StringBuilder(inputString); // Create a StringBuilder with the input string
        int length = stringBuilder.length(); // Get the length of the string

        // Iterate through the string and delete spaces
        for (int i = 0; i < length; i++) {
            if (stringBuilder.charAt(i) == ' ') { // Check if the character is a space
                stringBuilder.deleteCharAt(i); // Delete the space character
                length--; // Decrease the length after deletion
                i--; // Adjust index after deletion
            }
        }

        System.out.println("String without spaces: " + stringBuilder.toString()); // Display the result

        scanner.close(); // Close the scanner to free up resources
    }
}

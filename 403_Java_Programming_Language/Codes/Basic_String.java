// Question:
// Take a string from the user and print it in uppercase and lowercase.

import java.util.Scanner; // Import the Scanner class for user input

class Basic_String {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in); // Create a Scanner object to read input

        System.out.print("Enter a string: "); // Prompt the user for input
        String inputString = scanner.nextLine(); // Read the input string

        // Convert the string to uppercase and lowercase
        String upperCaseString = inputString.toUpperCase(); // Convert to uppercase
        String lowerCaseString = inputString.toLowerCase(); // Convert to lowercase

        // Print the results
        System.out.println("Uppercase: " + upperCaseString); // Display the uppercase string
        System.out.println("Lowercase: " + lowerCaseString); // Display the lowercase string

        scanner.close(); // Close the scanner to free up resources
    }
}
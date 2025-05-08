// Question:
// Write a Java program to input a string from the user and perform the following operations:
// Convert it to uppercase. | Find the length of the string | Reverse the string | Count the number of vowels in the string

import java.util.Scanner; // Import the Scanner class for user input

class StringMethods_v2 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in); // Create a Scanner object for user input

        System.out.print("Enter a string: "); // Prompt the user for input
        String inputString = scanner.nextLine(); // Read the input string

        // Convert to uppercase
        String upperCaseString = inputString.toUpperCase(); // Convert to uppercase
        System.out.println("Uppercase: " + upperCaseString); // Display the uppercase string

        // Find the length of the string
        int length = inputString.length(); // Get the length of the string
        System.out.println("Length of the string: " + length); // Display the length

        // Reverse the string
        String reversedString = new StringBuilder(inputString).reverse().toString(); // Reverse the string using StringBuilder
        System.out.println("Reversed string: " + reversedString); // Display the reversed string

        // Count the number of vowels in the string
        int vowelCount = 0; // Initialize vowel count
        for (char ch : inputString.toCharArray()) { // Iterate through each character in the string
            if ("aeiouAEIOU".indexOf(ch) != -1) { // Check if the character is a vowel
                vowelCount++; // Increment vowel count
            }
        }
        System.out.println("Number of vowels: " + vowelCount); // Display the number of vowels

        scanner.close(); // Close the scanner to free up resources
    }
}

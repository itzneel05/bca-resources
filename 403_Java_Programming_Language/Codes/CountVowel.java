// Question
// Write a program that counts the number of vowels, consonants, digits, and special characters in a given string.

import java.util.Scanner;

class CountVowel {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in); // Create a Scanner object to read input

        System.out.print("Enter a string: "); // Prompt the user for input
        String inputString = scanner.nextLine(); // Read the input string

        int vowelCount = 0; // Initialize vowel count
        int consonantCount = 0; // Initialize consonant count
        int digitCount = 0; // Initialize digit count
        int specialCharCount = 0; // Initialize special character count

        // Convert the string to lowercase for easier comparison
        String lowerCaseString = inputString.toLowerCase();

        // Iterate through each character in the string
        for (char ch : lowerCaseString.toCharArray()) {
            if (Character.isLetter(ch)) { // Check if the character is a letter
                if ("aeiou".indexOf(ch) != -1) { // Check if it's a vowel
                    vowelCount++; // Increment vowel count
                } else {
                    consonantCount++; // Increment consonant count
                }
            } else if (Character.isDigit(ch)) { // Check if the character is a digit
                digitCount++; // Increment digit count
            } else { // If it's neither a letter nor a digit, it's a special character
                specialCharCount++; // Increment special character count
            }
        }

        // Print the results
        System.out.println("Number of vowels: " + vowelCount);
        System.out.println("Number of consonants: " + consonantCount);
        System.out.println("Number of digits: " + digitCount);
        System.out.println("Number of special characters: " + specialCharCount);

        scanner.close(); // Close the scanner to free up resources
    }    
}

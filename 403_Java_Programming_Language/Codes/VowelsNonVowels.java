// Question:
// Write a program that accepts string data. Extract either All Vowels or All Non-Vowels from given Data According to Options Selection. Also Provide an Option to Display Output in Uppercase or Lowercase.

import java.util.Scanner; // Import the Scanner class for user input

class VowelsNonVowels {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in); // Create a Scanner object to read input

        System.out.print("Enter a string: "); // Prompt the user for input
        String inputString = scanner.nextLine(); // Read the input string

        System.out.println("Select an option: ");
        System.out.println("1. Extract Vowels");
        System.out.println("2. Extract Non-Vowels");
        int option = scanner.nextInt(); // Read the user's choice

        System.out.println("Select case: ");
        System.out.println("1. Uppercase");
        System.out.println("2. Lowercase");
        int caseOption = scanner.nextInt(); // Read the user's case choice

        StringBuilder result = new StringBuilder(); // Create a StringBuilder to store the result

        // Iterate through each character in the input string
        for (char ch : inputString.toCharArray()) {
            if (option == 1 && isVowel(ch)) { // Check if the character is a vowel
                result.append(ch); // Append the vowel to the result
            } else if (option == 2 && !isVowel(ch) && Character.isLetter(ch)) { // Check if it's a non-vowel and a letter
                result.append(ch); // Append the non-vowel to the result
            }
        }

        // Convert the result to uppercase or lowercase based on user's choice
        if (caseOption == 1) {
            System.out.println("Result in Uppercase: " + result.toString().toUpperCase()); // Display in uppercase
        } else {
            System.out.println("Result in Lowercase: " + result.toString().toLowerCase()); // Display in lowercase
        }

        scanner.close(); // Close the scanner to free up resources
    }

    // Helper method to check if a character is a vowel
    private static boolean isVowel(char ch) {
        return "aeiouAEIOU".indexOf(ch) != -1; // Check if the character is in the list of vowels
    }    
}

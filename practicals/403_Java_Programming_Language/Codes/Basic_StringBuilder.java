// Question:
// Use StringBuffer to reverse a string entered by the user.

import java.util.Scanner; // Import the Scanner class for user input

class Basic_StringBuilder {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in); // Create a Scanner object to read input

        System.out.print("Enter a string: "); // Prompt the user for input
        String inputString = scanner.nextLine(); // Read the input string

        StringBuilder stringBuilder = new StringBuilder(inputString); // Create a StringBuilder with the input string
        String reversedString = stringBuilder.reverse().toString(); // Reverse the string using StringBuilder

        System.out.println("Reversed string: " + reversedString); // Display the reversed string

        scanner.close(); // Close the scanner to free up resources    
    }   
}
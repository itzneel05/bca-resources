// Question:
// Write a java application which accepts two strings. Merge both the strings using alternate characters of each one.
// For example: If String1 is: "Very", and String2 is: "Good". Then result should be: "VGeoroyd"

import java.util.Scanner; // Import the Scanner class for user input

class Basic_String_v3 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in); // Create a Scanner object to read input

        System.out.print("Enter the first string: "); // Prompt the user for the first string
        String str1 = scanner.nextLine(); // Read the first string

        System.out.print("Enter the second string: "); // Prompt the user for the second string
        String str2 = scanner.nextLine(); // Read the second string

        char[] char1 = str1.toCharArray();
        char[] char2 = str2.toCharArray();
        
        for(int i = 0; i < char1.length; i++) {
            System.out.print(char1[i]); // Print character from the first string
            System.out.print(char2[i]); // Print character from the second string
            }
        }
    }


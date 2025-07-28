// Question
// Write a program a menu driven program which will do following operations. Declare a String object named str containing String "We are Full Stack Java Developer”.
// Display length of the String. | Display the first character of each word of the String. | Count total number of white spaces in the given string. | Display the first word in the String.
import java.util.Scanner; // Import the Scanner class for user input

class StringMethods {
    public void displayFirstCharacterOfEachWord(String str) {
        String[] words = str.split(" "); // Split the string into words using space as a delimiter
        System.out.print("First character of each word: "); // Print header for output
        for (String word : words) { // Iterate through each word
            if (!word.isEmpty()) { // Check if the word is not empty
                System.out.print(word.charAt(0) + " "); // Print the first character of the word
            }
        }
        System.out.println(); // Print a new line after displaying all first characters
    }

    public void countWhiteSpaces(String str) {
        int count = 0; // Initialize white space counter
        for (char ch : str.toCharArray()) { // Iterate through each character in the string
            if (ch == ' ') { // Check if the character is a white space
                count++; // Increment the counter
            }
        }
        System.out.println("Total number of white spaces: " + count); // Display the total count of white spaces
    }

    public void displayFirstWord(String str) {
        String firstWord = str.split(" ")[0]; // Get the first word by splitting the string at spaces
        System.out.println("First word in the String: " + firstWord); // Display the first word
    }
    public static void main(String[] args) {
        String str = "We are Full Stack Java Developer"; // Initialize the string
        Scanner scanner = new Scanner(System.in); // Create a Scanner object for user input
        StringMethods s = new StringMethods(); // Create an instance of the StringMethods class

        while (true) { // Infinite loop for menu-driven program
            System.out.println("Menu: ");
            System.out.println("1. String Length");
            System.out.println("2. First Character Of Each Word");
            System.out.println("3. Total White Spaces");
            System.out.println("4. First Word");
            System.out.println("5. Exit"); // Option to exit the program
            System.out.print("Enter your choice: "); // Prompt for user choice
            int choice = scanner.nextInt(); // Read user choice

            switch (choice) { // Switch case based on user choice
                case 1:
                    System.out.println("Length of the String: " + str.length()); // Display length of the string
                    break;
                case 2:
                    s.displayFirstCharacterOfEachWord(str); // Call method to display first character of each word
                    break;
                case 3:
                    s.countWhiteSpaces(str); // Call method to count white spaces
                    break;
                case 4:
                    s.displayFirstWord(str); // Call method to display first word
                    break;
                case 5:
                    System.out.println("Exiting..."); // Exit message
                    scanner.close(); // Close the scanner
                    return; // Exit the program
                default:
                    System.out.println("Invalid choice! Please try again."); // Handle invalid choice
            }
        }
    }
}
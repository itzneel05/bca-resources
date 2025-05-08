// Question:
// Create a menu-based program to perform multiple string operations (append, insert, reverse, delete) using StringBuffer.

class Basic_StringBuilder_v3 {
    public static void main(String[] args) {
        java.util.Scanner scanner = new java.util.Scanner(System.in); // Create a Scanner object for user input
        StringBuilder stringBuilder = new StringBuilder(); // Create a StringBuilder to perform operations

        while (true) { // Infinite loop for menu
            System.out.println("Menu:"); // Display menu options
            System.out.println("1. Append"); // Option to append
            System.out.println("2. Insert"); // Option to insert
            System.out.println("3. Reverse"); // Option to reverse
            System.out.println("4. Delete"); // Option to delete
            System.out.println("5. Exit"); // Option to exit
            System.out.print("Choose an option: "); // Prompt user for choice

            int choice = scanner.nextInt(); // Read user choice

            switch (choice) { // Switch case for menu options
                case 1: // Append operation
                    System.out.print("Enter string to append: "); // Prompt for string to append
                    String appendString = scanner.next(); // Read the string to append
                    stringBuilder.append(appendString); // Append the string
                    System.out.println("Current String: " + stringBuilder); // Display current string
                    break; // Break from switch case

                case 2: // Insert operation
                    System.out.print("Enter position to insert at: "); // Prompt for position to insert
                    int position = scanner.nextInt(); // Read the position
                    System.out.print("Enter string to insert: "); // Prompt for string to insert
                    String insertString = scanner.next(); // Read the string to insert
                    if (position >= 0 && position <= stringBuilder.length()) { // Check valid position
                        stringBuilder.insert(position, insertString); // Insert the string at specified position
                        System.out.println("Current String: " + stringBuilder); // Display current string
                    } else {
                        System.out.println("Invalid position!"); // Invalid position message
                    }
                    break; // Break from switch case

                case 3: // Reverse operation
                    stringBuilder.reverse(); // Reverse the current string in StringBuilder
                    System.out.println("Reversed String: " + stringBuilder); // Display reversed string
                    break; // Break from switch case

                case 4: // Delete operation
                    System.out.print("Enter start index to delete from: ");
                    int startIndex = scanner.nextInt(); // Read start index
                    System.out.print("Enter end index to delete to: "); // Prompt for end index 
                    int endIndex = scanner.nextInt(); // Read end index 
                    if (startIndex >= 0 && endIndex <= stringBuilder.length() && startIndex < endIndex) { // Check valid indices
                        stringBuilder.delete(startIndex, endIndex); // Delete substring from start to end index
                        System.out.println("Current String: " + stringBuilder); // Display current string
                    } else {
                        System.out.println("Invalid indices!"); // Invalid indices message
                    }
                    break; // Break from switch case
                case 5: // Exit operation
                    System.out.println("Exiting..."); // Exit message
                    scanner.close(); // Close the scanner
                    return; // Exit the program
                default: // Default case for invalid choice
                    System.out.println("Invalid choice! Please try again."); // Invalid choice message
                    break; // Break from switch case
            }
        }
    }
}

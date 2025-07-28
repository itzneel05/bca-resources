// Question:
// Write a Java program to display string with capital letters which are inputted through command line. Display those string(s) which starts with "B".


class Basic_String_v4 {
    public static void main(String[] args) {
        // Check if any command line arguments are provided
        if (args.length == 0) {
            System.out.println("No strings provided."); // Print message if no arguments are given
            return; // Exit the program
        }

        for (String str : args) { // Iterate through each command line argument
            System.out.print(str.toUpperCase() + " "); // Print each string provided in the command line arguments
        }

        System.out.println("\nStrings starting with 'B':"); // Print header for strings starting with 'B'
        // Iterate through each command line argument
        for (String str : args) {
            // Check if the string starts with 'B' or 'b'
            if (str.startsWith("B") || str.startsWith("b")) {
                System.out.print(str.toUpperCase() + " "); // Print the string in uppercase
            }
        }
    }
}

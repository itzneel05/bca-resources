// Question:
// Write a java program that accepts string from command line and display each character in capital at the delay of one second.

class CommandLine_v2 {
    public static void main(String[] args) {
        // Check if the user provided any command line arguments
        if (args.length == 0) {
            System.out.println("No command line arguments provided.");
            return;
        }

        String input = args[0]; // First argument is the string to be processed

        // Loop through each character in the string
        for (int i = 0; i < input.length(); i++) {
            char ch = input.charAt(i); // Get the character at index i
            System.out.print(Character.toUpperCase(ch)); // Convert to uppercase and print it
            try {
                Thread.sleep(1000); // Delay of one second
            } catch (Exception e) {}
        }
    }
}

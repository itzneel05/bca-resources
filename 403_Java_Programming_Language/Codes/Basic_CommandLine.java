// Question:
// Write a program to accept a name and age from command line and display it.

class Basic_CommandLine {
    public static void main(String[] args) {
        // Check if the user provided any command line arguments
        if (args.length == 0) {
            System.out.println("No command line arguments provided.");
        } else {
            String name = args[0]; // First argument is the name
            int age = 0; // Initialize age variable
            age = Integer.parseInt(args[1]); // Second argument is the age
            System.out.println("Name: " + name); // Display the name
            System.out.println("Age: " + age); // Display the age
        }    
    }
}
// Question:
// Accept multiple numbers from command line and print the largest number.

class LargeNumberLine {
    public static void main(String[] args) {
        // Check if the user provided any command line arguments
        if (args.length == 0) {
            System.out.println("No command line arguments provided.");
        } else {
            int largest = 0; // Initialize largest variable to the smallest integer value
            
            // Loop through each command line argument
            for (String arg : args) {
                int number = Integer.parseInt(arg); // Convert the argument to an integer
                if (number > largest) { // Check if the current number is larger than the current largest
                    largest = number; // Update largest if true
                }
            }
            
            System.out.println("Largest number: " + largest); // Display the largest number
        }    
    }    
}

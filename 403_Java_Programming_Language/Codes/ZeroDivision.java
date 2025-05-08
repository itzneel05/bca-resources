// Question:
// Write a Java program that takes two numbers as input and performs division. Handle exceptions for division by zero and invalid input
class ZeroDivision {
    public static void main(String[] args) {
        if (args.length < 2) { // Check if two arguments are provided
            System.out.println("Please provide two numbers for division.");
            return;
        }
        try {
            int num1 = Integer.parseInt(args[0]); // Parse first argument as integer
            int num2 = Integer.parseInt(args[1]); // Parse second argument as integer

            // Perform division and handle division by zero
            int result = num1 / num2; // This may cause ArithmeticException
            System.out.println("Result: " + result); // Print the result
        } catch (ArithmeticException e) { // Handle division by zero
            System.out.println("Error: Cannot divide by zero.");
        } catch (NumberFormatException e) { // Handle invalid input format
            System.out.println("Error: Invalid input. Please enter valid integers.");
        } finally {
            System.out.println("Execution completed."); // This block always executes
        }
    }
}

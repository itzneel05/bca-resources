// Question:
// Create a program that handles ArithmeticException for divide-by-zero.

class Basic_ErrorHandling {
    public static void main(String[] args) {
        int num1 = 10;
        int num2 = 0; // This will cause divide by zero error

        try {
            // Attempt to perform division
            int result = num1 / num2;
            System.out.println("Result: " + result);
        } catch (ArithmeticException e) {
            // Handle the exception
            System.out.println("Error: Cannot divide by zero.");
        } finally {
            // This block always executes
            System.out.println("Execution completed.");
        }
    }    
}

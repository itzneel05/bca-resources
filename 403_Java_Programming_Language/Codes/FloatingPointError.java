// Question:
// Write a Java code that handles the custom exception like when a user gives input as Floating point number then it raises exception with appropriate message.

class FloatingPointException extends Exception {
    // Constructor to initialize the exception message
    public FloatingPointException(String message) {
        super(message); // Call the constructor of the parent class (Exception)
    }
}

class FloatingPointError {
    public static void main(String[] args) {
        // Check if the user provided any command line arguments
        if (args.length == 0) {
            System.out.println("No command line arguments provided.");
            return;
        }

        String input = args[0]; // First argument is the number in string format

        try {
            // Attempt to parse the input as a double
            double number = Double.parseDouble(input);

            // Check if the number is an integer (no decimal part)
            if (number % 1 != 0) {
                throw new FloatingPointException("Error: Input is a floating point number: " + number);
            } else {
                System.out.println("Input is a valid integer: " + (int) number);
            }
        } catch (FloatingPointException e) {
            System.out.println(e.getMessage()); // Display the custom error message
        } catch (NumberFormatException e) {
            System.out.println("Invalid input. Please enter a valid integer.");
        }
    }    
}

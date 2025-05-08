// Question:
// Write a program that will accept a number from command line and raise a user defined exception if the number consists of odd number of digits.
class OddDigitException extends Exception {
    public OddDigitException(String message) {
        super(message); // Call the constructor of the parent Exception class
    }
}
class Basic_CustomError_v2 {
    public static void main(String[] args) {
        // Check if the user provided any command line arguments
        if (args.length == 0) {
            System.out.println("No command line arguments provided.");
            return;
        }

        String input = args[0]; // First argument is the number in string format

        try {
            int digitCount = input.length(); // Get the number of digits

            // Check if the number of digits is odd
            if (digitCount % 2 != 0) {
                throw new OddDigitException("Error : Number has an odd number of digits: " + digitCount);
            } else {
                System.out.println("Number has an even number of digits: " + digitCount);
            }
        } catch (OddDigitException e) {
            System.out.println(e.getMessage()); // Display the custom error message
        } catch (NumberFormatException e) {
            System.out.println("Invalid input. Please enter a valid integer.");
        }
    }
}
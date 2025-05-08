// Question:
// Write a program that throws a custom InvalidAgeException if age is less than 18.

class InvalidAgeException extends Exception {
    // Constructor to initialize the exception message
    public InvalidAgeException(String message) {
        super(message); // Call the constructor of the parent class (Exception)
    }
}
class Basic_CustomError {
    // Method to check age and throw exception if invalid
    public static void checkAge(int age) throws InvalidAgeException {
        if (age < 18) { // Check if age is less than 18
            throw new InvalidAgeException("Age must be 18 or older."); // Throw custom exception
        } else {
            System.out.println("Valid age: " + age); // Print valid age
        }
    }

    public static void main(String[] args) {
        try {
            checkAge(16); // Test with an invalid age
        } catch (InvalidAgeException e) { // Catch the custom exception
            System.out.println("Caught exception: " + e.getMessage()); // Print exception message
        }
    }
}
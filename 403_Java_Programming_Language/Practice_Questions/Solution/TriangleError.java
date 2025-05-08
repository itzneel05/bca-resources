// Question:
// Write a Java program that prompts the user to input the base and height of a triangle. Accordingly calculates and displays the area of a triangle using the formula (base*height) / 2, and handles any input errors such as non-numeric inputs or negative values for base or height. Additionally, include error messages for invalid input and provide the user with the option to input another set of values or exit the program.
import java.util.Scanner; // Import Scanner class for user input

class IllegalArgumentException extends Exception {
    public IllegalArgumentException(String message) {
        super(message); // Call the constructor of the parent Exception class
    }
}
class TriangleError {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in); // Create a Scanner object for user input

        int ch = 0;
        while (ch!=1) { // Infinite loop to allow multiple inputs

            try {
                System.out.print("Enter the base of the triangle: ");
                double base = Double.parseDouble(scanner.nextLine()); // Read and parse base input

                System.out.print("Enter the height of the triangle: ");
                double height = Double.parseDouble(scanner.nextLine()); // Read and parse height input

                // Check for negative values
                if (base < 0 || height < 0) {
                    throw new IllegalArgumentException("Base and height must be non-negative values.");
                }

                // Calculate area of the triangle
                double area = (base * height) / 2;
                System.out.println("Area of the triangle: " + area); // Display the calculated area

            } catch (NumberFormatException e) { // Handle non-numeric input
                System.out.println("Invalid input. Please enter numeric values for base and height.");
            } catch (IllegalArgumentException e) { // Handle negative values
                System.out.println(e.getMessage());
            }

            // Ask user if they want to continue or exit
            System.out.print("Do you want to calculate another triangle area? (1 for Yes, 0 for No): ");
            ch = scanner.nextInt(); // Read user choice
            scanner.nextLine(); // Consume the newline character left by nextInt()
            }

        scanner.close(); // Close the scanner resource
    }   
}

// Question:
// Implement an interface that accepts input from the user and processes it in the implementing class.

import java.util.Scanner; // Import Scanner class for user input
interface StudentDetails {
    void getStudentDetails(); // Method to be implemented by classes that implement this interface
    void displayStudentDetails(); // Method to be implemented by classes that implement this interface
}

class Student implements StudentDetails {
    private String name; // Name of the student
    private int age; // Age of the student
    private String course; // Course enrolled by the student

    // This Method to get student details from user input
    @Override
    public void getStudentDetails() {
        Scanner scanner = new Scanner(System.in); // Create a Scanner object for user input
        System.out.print("Enter student name: ");
        name = scanner.nextLine(); // Read student name from user input
        System.out.print("Enter student age: ");
        age = scanner.nextInt(); // Read student age from user input
        scanner.nextLine(); // Consume the newline character left by nextInt()
        System.out.print("Enter course enrolled: ");
        course = scanner.nextLine(); // Read course from user input
        scanner.close(); // Close the scanner to prevent resource leaks
    }

    // This Method to display student details
    @Override
    public void displayStudentDetails() {
        System.out.println("Student Name: " + name); // Display student name
        System.out.println("Student Age: " + age); // Display student age
        System.out.println("Course Enrolled: " + course); // Display course enrolled
    }
}

class Userinput_Interface {
    public static void main(String[] args) {
        Student student = new Student(); // Create an instance of Student class
        student.getStudentDetails(); // Call the method to get student details from user input
        student.displayStudentDetails(); // Call the method to display student details
    }
}

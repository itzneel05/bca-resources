// Question:
// Create class EMPLOYEE in java with id, name and salary as data-members.
// Again create 5 different employee objects by taking input from user.
// Display all the information of an employee which is having maximum salary.

import java.util.Scanner; // Import Scanner class for user input

class Employee {
    private int id;
    private String name;
    private double salary;

    // Constructor for inserting employee information
    public Employee(int id, String name, double salary) {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }

    // Method to display employee information
    public void display() {
        System.out.println("ID: " + id);
        System.out.println("Name: " + name);
        System.out.println("Salary: " + salary);
    }

    // Getter for salary
    public double getSalary() {
        return salary;
    }
}

class Basic_Class_v3 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Employee[] employees = new Employee[5]; // Array to hold 5 employee objects

        // Input employee information from user
        for (int i = 0; i < 5; i++) {
            System.out.println("Enter details for Employee " + (i + 1) + ":");
            System.out.print("ID: ");
            int id = scanner.nextInt();
            System.out.print("Name: ");
            String name = scanner.next();
            System.out.print("Salary: ");
            double salary = scanner.nextDouble();

            employees[i] = new Employee(id, name, salary); // Create and store employee object
        }

        // Find the employee with maximum salary
        Employee maxSalaryEmployee = employees[0];
        for (int i = 1; i < employees.length; i++) {
            if (employees[i].getSalary() > maxSalaryEmployee.getSalary()) {
                maxSalaryEmployee = employees[i];
            }
        }

        // Display the information of the employee with maximum salary
        System.out.println("\nEmployee with Maximum Salary:");
        maxSalaryEmployee.display(); // Display employee information

        scanner.close(); // Close the scanner to avoid resource leaks
    }
}

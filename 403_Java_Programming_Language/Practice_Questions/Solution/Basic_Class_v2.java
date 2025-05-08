// Question:
// Create a Student Class with Attributes : name, rollNo and marks.
// Implement a method display() to show student details. Create two student objects and display their details.

class Student {
    private String name;
    private int rollNo;
    private double marks;

    // Constructor for inserting student information
    public Student(String name, int rollNo, double marks) {
        this.name = name;
        this.rollNo = rollNo;
        this.marks = marks;
    }

    // Method to display student information
    public void display() {
        System.out.println("Name: " + name);
        System.out.println("Roll No: " + rollNo);
        System.out.println("Marks: " + marks);
    }
}

class Basic_Class_v2 {
    public static void main(String[] args) {
        // Create two student objects with sample data
        Student student1 = new Student("Neel", 101, 85.5);
        Student student2 = new Student("Bob", 102, 90.0);

        // Display their details
        System.out.println("Student 1 Details:");
        student1.display(); // Display student 1 information

        System.out.println("\nStudent 2 Details:");
        student2.display(); // Display student 2 information
    }
}

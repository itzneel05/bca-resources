import studentdata.Student;
import studentops.Operations;

public class StudentMain {
    public static void main(String[] args) {
        Student[] students = {
            new Student(102, "Neel"),
            new Student(101, "Bob"),
            new Student(103, "Krish")
        };

        System.out.println("Original List:");
        for (Student s : students) {
            s.display();
        }

        // Sort students
        Operations.sortByRoll(students);
        System.out.println("\nSorted by Roll No:");
        for (Student s : students) {
            s.display();
        }

        // Search student
        int searchRoll = 101;
        Student found = Operations.searchByRoll(students, searchRoll);
        System.out.println("\nSearch Result:");
        if (found != null) {
            found.display();
        } else {
            System.out.println("Student with roll no " + searchRoll + " not found.");
        }
    }
}
